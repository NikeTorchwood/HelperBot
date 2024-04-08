using DataAccess.Entities;

namespace DataAccess.Repositories.Abstractions;

public interface IProductRepository: IRepository<Product, int>
{
    public IEnumerable<Product> GetProductsByArticleId(int articleId);
    public IEnumerable<Product> GetProductsByStoreId(int storeId);

}