using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using _01_Framework.Infrastructure;
using MB.Application.Contracts;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository, IUnitOfWork unitOfWork)
        {
            _articleCategoryRepository = articleCategoryRepository;
            _unitOfWork = unitOfWork;
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
            _unitOfWork.BeginTran();
            var articleCategory = new ArticleCategory(command.Title );
            _articleCategoryRepository.Add(articleCategory);
            _unitOfWork.CommitTran();
        }

        public void Rename(RenameArticleCategory command)
        {
            _unitOfWork.BeginTran();
            var articleCategory = _articleCategoryRepository.Get(command.Id);
            articleCategory.Rename(command.Title);

            _articleCategoryRepository.Save();
            _unitOfWork.CommitTran();
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
            _unitOfWork.BeginTran();
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Remove();
            _articleCategoryRepository.Save();
            _unitOfWork.CommitTran();

        }

        public void Activate(long id)
        {
            _unitOfWork.BeginTran();
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Activate();
            _articleCategoryRepository.Save();
            _unitOfWork.CommitTran();
        }
    }
}
