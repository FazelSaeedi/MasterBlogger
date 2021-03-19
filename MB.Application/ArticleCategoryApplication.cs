using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using MB.Application.Contracts;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.ArticleCategoryAgg.Services;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {

        private readonly IArticleCategoryRepository _articleCategoryRepository;

        private readonly IArticleCategoryValidatorService _articleCategoryValidatorService;
        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        public List<ArticleCategoryViewModel> List()
        {

            
            var articleCategories = _articleCategoryRepository.GetAll();

            return articleCategories.Select(articleCategory => new ArticleCategoryViewModel
            {
                Id = articleCategory.Id,
                Title = articleCategory.Title,
                IsDeleted = articleCategory.IsDeleted,
                CreationDate = articleCategory.CreationDate.ToString(CultureInfo.InvariantCulture)
            }).ToList();


        }

        public void Create(CreateArticleCategory command)
        {
            var articleCategory = new ArticleCategory(command.Title , _articleCategoryValidatorService);
            _articleCategoryRepository.Add(articleCategory);
        }

        public void Rename(RenameArticleCategory command)
        {
            var articleCategory = _articleCategoryRepository.Get(command.Id);
            articleCategory.Rename(command.Title);

            _articleCategoryRepository.Save();
        }

        public RenameArticleCategory Get(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);

            return new RenameArticleCategory()
            {
                Id = articleCategory.Id,
                Title = articleCategory.Title
            };
        }

        public void Remove(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Remove();
            _articleCategoryRepository.Save();
        }

        public void Activate(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Activate();
            _articleCategoryRepository.Save();
        }
    }
}
