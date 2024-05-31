using Walks.Data;
using Walks.Models.Domain;

namespace Walks.Repositories;

public class LocalImageRepository : IImageRepository
{
    private readonly IWebHostEnvironment webHostEnvironment;
    private readonly IHttpContextAccessor httpContextAccessor;
    private readonly WalksDbContext dbContext;

    public LocalImageRepository(IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, WalksDbContext dbContext)
    {
        this.webHostEnvironment = webHostEnvironment;
        this.httpContextAccessor = httpContextAccessor;
        this.dbContext = dbContext;
    }

    public IHttpContextAccessor HttpContextAccessor { get; }

    public async Task<Image> Upload(Image image)
    {
        var filePath = Path.Combine(webHostEnvironment.ContentRootPath, "images", $"{image.FileName}{image.FileExtension}");

        // Upload image to local storage
        using var fileStream = new FileStream(filePath, FileMode.Create);
        await image.File.CopyToAsync(fileStream);
        // Create image url using request scheme and host
        var urlFile = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/images/{image.FileName}{image.FileExtension}";
        image.FilePath = urlFile;

        // Add image to database
        await dbContext.Images.AddAsync(image);
        await dbContext.SaveChangesAsync();

        return image;
    }
}