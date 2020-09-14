using System.Threading.Tasks;
using Core.Repositories;

namespace Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        Task CommitAsync();
        Task Commit();
    }
}