using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contracts;
using MB.Application.Contracts.ArticleCategory;
using MB.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.ArticleCategoryManagement
{
    public class ListModel : PageModel
    {
        public List<ArticleCategoryViewModel> ArticleCategories { get; set; }

        private readonly IArticleCategoryApplication _articleCategoryApplication;

        private readonly MasterBloggerContext _context;

        public ListModel(IArticleCategoryApplication articleCategoryApplication, MasterBloggerContext context)
        {
            _articleCategoryApplication = articleCategoryApplication;
            _context = context;
        }


        public void OnGet()
        {
            ArticleCategories = _articleCategoryApplication.List();
            //var article = _context.ArticleCategories.ToList();
        }

        public RedirectToPageResult OnPostRemove(long id)
        {
            _articleCategoryApplication.Remove(id);
            return RedirectToPage("./List");
;       }

        public RedirectToPageResult OnPostActivate(long id)
        {
            _articleCategoryApplication.Activate(id);
            return RedirectToPage("./List");
        }
    }
}
