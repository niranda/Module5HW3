namespace Catalog.Host.Data
{
    public class IdItems<T>
    {
        public long TotalCount { get; init; }

        public T? Data { get; init; }

        public int? Id { get; init; }
    }
}
