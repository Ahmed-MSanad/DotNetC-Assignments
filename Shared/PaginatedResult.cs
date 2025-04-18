namespace Shared
{
    public record PaginatedResult<TEntity>(int pageIndex, int pageSize, int totalItemCount, IEnumerable<TEntity> data);
}
