using DataAccess.Entities;

namespace DataAccess.Repositories.Abstractions;

public interface IArticleRepository : IRepository<Article, int>
{
    public IEnumerable<Article> GetArticlesByProductModelId (int productModelId);
}
