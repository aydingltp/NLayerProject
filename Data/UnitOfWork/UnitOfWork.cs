using System.Threading.Tasks;
using Core.Repositories;
using Core.UnitOfWorks;

namespace Data.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly ProductRepository _productRepository;
        private readonly CategoryRepository _categoryRepository;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        
        public IProductRepository Product { get; }
        public ICategoryRepository Category { get; }
        public Task CommitAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task Commit()
        {
            throw new System.NotImplementedException();
        }
    }
}