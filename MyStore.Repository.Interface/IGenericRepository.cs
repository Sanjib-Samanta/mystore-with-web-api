using System.Linq;

namespace MyStore.Repository.Interface
{
  public interface IGenericRepository<T> where T : class
  {
    IQueryable<T> GetAll();
  }
}
