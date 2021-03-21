using System;
using System.Collections;
using System.Collections.Generic;
using _01_Framework.Domain;
using MB.Domain.ArticleAgg;


namespace MB.Domain.ArticleCategoryAgg
{
    public class ArticleCategory : DomainBase<long>
    {
        public string Title { get; set; }
        public bool IsDeleted { get; private set; }

        public ICollection<Article> Articles { get; set; }

        public ArticleCategory(string title)
        {
            Title = title;
            Articles = new List<Article>();
            IsDeleted = false;
        }


        public void Rename(string title)
        {
            this.Title = title ;
        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void Activate()
        {
            IsDeleted = false;
        }
    }
}