namespace HotelListingAPI.Test
{
    public abstract class DisposableTestBase : IDisposable
    {
        protected abstract void Dispose(bool disposing);
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}