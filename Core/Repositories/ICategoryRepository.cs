using System.Threading.Tasks;
using Core.Models;

namespace Core.Repositories
{
    public interface ICategoryRepository: IRepository<Category>
    {
        // Category ye özel işlemleri için 
        Task<Category> GetWithProductsByIdAsync(int categoryId);
        
        
    }
}