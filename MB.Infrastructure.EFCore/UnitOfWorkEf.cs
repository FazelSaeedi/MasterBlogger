using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Framework.Infrastructure;

namespace MB.Infrastructure.EFCore
{
    public class UnitOfWorkEf : IUnitOfWork
    {
        private readonly MasterBloggerContext _context;

        public UnitOfWorkEf(MasterBloggerContext context)
        {
            _context = context;
        }

        public void BeginTran()
        {
            _context.Database.BeginTransaction();
        }

        public void CommitTran()
        {
            _context.SaveChanges();
            _context.Database.CommitTransaction();
        }

        public void Rollback()
        {
            _context.Database.RollbackTransaction();
        }
    }
}
