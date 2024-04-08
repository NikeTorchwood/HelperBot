using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Implementations
{
    public class ArticleRepository(DbContext context) : Repository<Article, int>(context), IArticleRepository
    {
        public IEnumerable<Article> GetArticlesByProductModelId(int productModelId)
        {
            return GetAll().Where(a => a.ProductModelId == productModelId);
        }
    }
}
