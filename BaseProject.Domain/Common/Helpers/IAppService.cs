using BaseProject.Domain.Common.Helpers.DataTablePaginationServer;
using System.Linq.Expressions;

namespace BaseProject.Domain.Common.Helpers
{
    public interface IAppService
    {
        List<T> GetData<T>(PaginationConfiguration outf, IQueryable<T> table, Expression<Func<T, bool>> condition);
    }
}
