using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleCategoryAgg.Exceptions
{
    public class DublicatedRecordException : Exception
    {
        public DublicatedRecordException() 
        {

        }

        public DublicatedRecordException(string message) : base(message)
        {
            
        }
    }
}
