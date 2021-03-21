using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Framework.Infrastructure;
using MB.Application.Contracts.Comment;
using MB.Domain.CommentAgg;

namespace MB.Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ICommentRepository _commentRepository;

        public CommentApplication(ICommentRepository commentRepository, IUnitOfWork unitOfWork)
        {
            _commentRepository = commentRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(AddComment commant)
        {
            _unitOfWork.BeginTran();
            var comment = new Comment(commant.Name, commant.Email, commant.Message, commant.ArticleId);
            _commentRepository.CreateAndSave(comment);
            _unitOfWork.CommitTran();

        }

        public List<CommentViewModel> GetList()
        {
            return _commentRepository.GetList();
        }

        public void Confirm(long id)
        {
            _unitOfWork.BeginTran();
            var Comment = _commentRepository.Get(id);
            Comment.Confirm();
            _commentRepository.Save();
            _unitOfWork.CommitTran();
        }

        public void Cansel(long id)
        {
            _unitOfWork.BeginTran();
            var Comment = _commentRepository.Get(id);
            Comment.Cansel();
            _commentRepository.Save();
            _unitOfWork.CommitTran();
        }
    }
}
