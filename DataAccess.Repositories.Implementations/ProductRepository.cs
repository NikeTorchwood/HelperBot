using DataAccess.Entities;
using DataAccess.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class ProductRepository(DbContext context) : Repository<Product, int>(context), IProductRepository
    {
        public IEnumerable<Product> GetProductsByArticleId(int articleId)
        {
            return GetAll().Where(p => p.ArticleId == articleId);
        }

        public IEnumerable<Product> GetProductsByStoreId(int storeId)
        {
            return GetAll().Where(p => p.StoreId == storeId);
        }
    }
}
