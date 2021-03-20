using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB.Application.Contracts.Comment;
using MB.Domain.CommentAgg;

namespace MB.Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly ICommentRepository _commentRepository;

        public CommentApplication(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void Add(AddComment commant)
        {
            var comment = new Comment(commant.Name, commant.Email, commant.Message, commant.ArticleId);
            _commentRepository.CreateAndSave(comment);
        }

        public List<CommentViewModel> GetList()
        {
            return _commentRepository.GetList();
        }

        public void Confirm(long id)
        {
            var Comment = _commentRepository.Get(id);
            Comment.Confirm();
            _commentRepository.Save();
        }

        public void Cansel(long id)
        {
            var Comment = _commentRepository.Get(id);
            Comment.Cansel();
            _commentRepository.Save();
        }
    }
}
