
namespace Walks.Models.Domain;

public interface IImageRepository
{
    Task<Image> Upload(Image image);
}