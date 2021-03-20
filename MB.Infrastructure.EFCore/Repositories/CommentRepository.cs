﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB.Application.Contracts.Comment;
using MB.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;

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

        public List<CommentViewModel> GetList()
        {
            return _context.Comments.Include(x => x.Article).Select(x => new CommentViewModel
            {
                Id = x.Id ,
                Name = x.Name ,
                Email = x.Email ,
                Message = x.Message ,
                Status = x.Status ,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                Article = x.Article.Title
            }).ToList();
        }

        public Comment Get(long id)
        {
            return _context.Comments.FirstOrDefault(x => x.Id == id);
        }

        public void Save()
        {
            _context.SaveChanges();

        }
    }
}
