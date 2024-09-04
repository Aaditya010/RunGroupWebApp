using CloudinaryDotNet.Actions;

namespace RunGroupWebApp.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult>AddPhotoAsync(IFormFile file);
        Task AddPhotoAsync(string image);
        Task<DeletionResult>DeletePhotoAsync(string publicId);
    }
}
