using System;
using MB.Domain.ArticleCategoryAgg.Services;


namespace MB.Domain.ArticleCategoryAgg
{
    public class ArticleCategory 
    {
        public long Id{ get; private set; }
        public string Title { get; set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }


        public ArticleCategory(string title , IArticleCategoryValidatorService validatorService)
        {
            Title = title;
            validatorService.CheckOneArticleAlreadyExist(title);

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