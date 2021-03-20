using System;
using System.Collections;
using System.Collections.Generic;
using MB.Domain.ArticleAgg;


namespace MB.Domain.ArticleCategoryAgg
{
    public class ArticleCategory 
    {
        public long Id{ get; private set; }
        public string Title { get; set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }

        public ICollection<Article> Articles { get; set; }


        public ArticleCategory()
        {

        }

        public ArticleCategory(string title)
        {
            Title = title;
            Articles = new List<Article>();
            IsDeleted = false;
            CreationDate = DateTime.Now;
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