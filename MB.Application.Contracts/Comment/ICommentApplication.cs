using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Contracts.Comment
{
    public interface ICommentApplication
    {
        void Add(AddComment commant);

        List<CommentViewModel> GetList();

        void Confirm(long id);
        void Cansel(long id);
    }
}
