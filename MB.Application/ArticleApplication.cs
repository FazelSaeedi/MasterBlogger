using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Framework.Infrastructure;
using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;

namespace MB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IArticleRepository _articleRepository;

        public ArticleApplication(IArticleRepository articleRepository, IUnitOfWork unitOfWork)
        {
            _articleRepository = articleRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ArticleViewModel> GetList()
        {
            return _articleRepository.GetList();
        }

        public void Create(CreateArticle command)
        {
            _unitOfWork.BeginTran();
            var article = new Article(command.Title, command.ShortDescription, command.Image, command.Content,
                command.ArticleCategoryId);

            _articleRepository.CreateArticle(article);
            _unitOfWork.CommitTran();
        }

        public void Edit(EditArticle command)
        {
            _unitOfWork.BeginTran();
            var article =  _articleRepository.Get(command.Id);

           article.Edit(command.Title, command.ShortDescription, command.Image, command.Content,
               command.ArticleCategoryId);

           _articleRepository.Save();
           _unitOfWork.CommitTran();
        }

        public EditArticle Get(long id)
        {
            var article = _articleRepository.Get(id);
            return new EditArticle
            {
                Id = article.Id ,
                Title = article.Title ,
                Image = article.Image,
                Content = article.Content ,
                ArticleCategoryId = article.ArticleCategoryId ,
                ShortDescription = article.ShortDescription
                 
            };
        }

        public void Remove(long id)
        {
            _unitOfWork.BeginTran();
            var article = _articleRepository.Get(id);
            article.Remove();
            _articleRepository.Save();
            _unitOfWork.CommitTran();
        }

        public void Activate(long id)
        {
            _unitOfWork.BeginTran();
            var article = _articleRepository.Get(id);
            article.Activate();
            _articleRepository.Save();
            _unitOfWork.CommitTran();
        }
    }
}
