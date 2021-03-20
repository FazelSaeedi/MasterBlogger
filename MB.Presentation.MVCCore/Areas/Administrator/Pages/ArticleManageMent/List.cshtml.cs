using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;
using MB.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.ArticleManageMent
{
    public class ListModel : PageModel
    {
        public List<ArticleViewModel> Articles { get; set; }

        private readonly IArticleApplication _articleApplication;



        public ListModel(IArticleApplication articleApplication, MasterBloggerContext context, IArticleRepository articleRepository)
        {
            _articleApplication = articleApplication;
        }

        public void OnGet()
        {
            Articles = _articleApplication.GetList();
        }

        public RedirectToPageResult OnPostRemove(long id)
        {
            _articleApplication.Remove(id);
            return RedirectToPage("./List");
        }

        public RedirectToPageResult OnPostActivate(long id)
        {

            _articleApplication.Activate(id);
            return RedirectToPage("./List");
        }
    }
}
