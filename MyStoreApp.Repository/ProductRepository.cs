using MyStore.Database;
using System.Collections.Generic;
using System.Linq;

namespace MyStoreApp.Repository
{
  public interface IProductRepository
  {
    IEnumerable<Product> GetProducts();
  }

  public class ProductRepository : IProductRepository
  {
    IMyStoreEntities _myStoreDbContext;

    public ProductRepository(IMyStoreEntities dbContext)
    {
      _myStoreDbContext = dbContext;
    }

    public IEnumerable<Product> GetProducts()
    {
      return _myStoreDbContext.Products.ToList();
    }
  }
}
