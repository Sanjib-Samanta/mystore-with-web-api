using MyStore.Database;
using MyStore.Repository.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace MyStoreApp.Controllers
{
  public class ProductController : ApiController
  {
    private readonly IGenericRepository<Product> _productRepository;

    public ProductController(IGenericRepository<Product> repository)
    {
      _productRepository = repository;
    }

    public IEnumerable<Product> GetProducts()
    {
      return _productRepository.GetAll();
    }
  }
}
