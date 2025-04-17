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
    }
}
