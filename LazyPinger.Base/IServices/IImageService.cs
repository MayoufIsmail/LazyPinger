using System.Threading.Tasks;

namespace LazyPinger.Base.IServices
{
    public interface IImageService<T>
    {
        public Task<byte[]> ImageToBytes(T image);

        public T BytesToImage(byte[] data);

        public Task ResizeImage(int width, int height);
    }
}
