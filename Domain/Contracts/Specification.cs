using System.Linq.Expressions;

namespace Domain.Contracts
{
    public abstract class Specification<T> where T : class
    {
        protected Specification(Expression<Func<T, bool>> _criteria) // Expression<Func<T, bool>> as Criteria will be passed to Where clause
        {
            Criteria = _criteria;
        }
        public Expression<Func<T, bool>> Criteria { get; }


        public List<Expression<Func<T, object>>> Includes { get; } = new(); // new List<Expression<Func<T, object>>>();
        // List<Expression<Func<T, object>>> -> is list of what the Includes clause can take, list as we can have multiple includes
            // such as ProductBrand & ProductType.
        protected void AddInclude(Expression<Func<T, object>> include)
            => Includes.Add(include); // Add the include expression to the list of includes


        public Expression<Func<T, object>> OrderBy { get; private set; }
        protected void SetOrderBy(Expression<Func<T, object>> orderBy)
            => OrderBy = orderBy; // Set the sorting expression for ascending order


        public Expression<Func<T, object>> OrderByDescending { get; private set; }
        protected void SetOrderByDescending(Expression<Func<T, object>> orderByDescending)
            => OrderByDescending = orderByDescending; // Set the sorting expression for descending order

        public int Take { get; private set; }
        public int Skip { get; private set; }
        public bool isPaginated { get; private set; }
        protected void ApplyPagination(int pageIndex, int pageSize)
        {
            isPaginated = true;
            Take = pageSize;
            Skip = (pageIndex - 1) * pageSize;
        }
    }
}
