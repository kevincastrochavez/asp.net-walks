using Microsoft.AspNetCore.Mvc;

namespace Walks.Models.Domain;

[ApiController]
[Route("[controller]")]
public class ImagesController : ControllerBase
{
    [HttpPost(Name = "Upload")]
    public async Task<IActionResult> Upload([FromForm] ImageUploadDto imageUploadDto)
    {
        ValidateFileUpload(imageUploadDto);
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok();
    }

    private void ValidateFileUpload(ImageUploadDto imageUploadDto)
    {
        var allowedExtensions = new List<string> { ".jpg", ".jpeg", ".png" };
        var tenMegaBytes = 10 * 1024 * 1024;

        if (!allowedExtensions.Contains(Path.GetExtension(imageUploadDto.File.FileName).ToLower()))
        {
            ModelState.AddModelError("File", "File type not allowed");
        }

        if (imageUploadDto.File.Length > tenMegaBytes)
        {
            ModelState.AddModelError("File", "File size too large");
        }
    }
}