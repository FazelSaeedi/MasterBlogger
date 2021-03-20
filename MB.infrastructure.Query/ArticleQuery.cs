using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using MB.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace MB.infrastructure.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly MasterBloggerContext _context;

        public ArticleQuery(MasterBloggerContext context)
        {
            _context = context;
        }

        public List<ArticleQueryView> GetArticles()
        {
            return _context.Articles.Include(x => x.ArticleCategory).Select(x => new ArticleQueryView
            {
                Id = x.Id ,
                Title = x.Title ,
                ArticleCategory = x.Content ,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                ShortDescription = x.ShortDescription ,
                Image = x.Image
            }).ToList();
        }

        public ArticleQueryView GetArticle(long id)
        {
            return _context.Articles.Include(x => x.ArticleCategory).Select(x => new ArticleQueryView
            {
                Id = x.Id,
                Title = x.Title,
                ArticleCategory = x.Content,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                ShortDescription = x.ShortDescription,
                Image = x.Image ,
                Content = x.Content
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}