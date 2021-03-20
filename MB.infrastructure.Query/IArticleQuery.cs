using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.infrastructure.Query
{
    public interface IArticleQuery
    {
        List<ArticleQueryView> GetArticles();

        ArticleQueryView GetArticle(long id);
    }
}
