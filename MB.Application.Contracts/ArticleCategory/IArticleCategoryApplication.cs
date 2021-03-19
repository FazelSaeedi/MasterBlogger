using System;
using System.Collections.Generic;
using MB.Application.Contracts.ArticleCategory;

namespace MB.Application.Contracts
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> List();

        void Create(CreateArticleCategory command);

        void Rename(RenameArticleCategory command);

        RenameArticleCategory Get(long id);

        void Remove(long id);

        void Activate(long id);
    }
}
