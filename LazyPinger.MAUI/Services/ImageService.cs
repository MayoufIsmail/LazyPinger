using LazyPinger.Base.IServices;

namespace LazyPinger.Core.Services
{
    public class ImageService : IImageService<ImageSource>
    {
        public ImageSource BytesToImage(byte[] data)
        {
            return ImageSource.FromStream(() => new MemoryStream(data));
        }

        public async Task<byte[]> ImageToBytes(ImageSource image)
        {
            using var ms = new MemoryStream();

            await ms.CopyToAsync(ms);
            var imageBytes = ms.ToArray();
            return imageBytes;
        }

        public Task ResizeImage(int width, int height)
        {
            throw new NotImplementedException();
        }
    }
}
