using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB.Domain.CommentAgg;

namespace MB.Infrastructure.EFCore.Repositories
{

    public class CommentRepository : ICommentRepository
    {
        public readonly MasterBloggerContext _context;

        public CommentRepository(MasterBloggerContext context)
        {
            _context = context;
        }

        public void CreateAndSave(Comment comment)
        {
            _context.Add(comment);
            Save();
        }

        private void Save()
        {
            _context.SaveChanges();
        }
    }
}
