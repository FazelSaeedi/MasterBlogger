using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contracts;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.ArticleCategoryManagement
{

    public class EditModel : PageModel
    {
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public EditModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        [BindProperty] public RenameArticleCategory ArticleCategory { get; set; }

        public void OnGet(long id)
        {
            ArticleCategory = _articleCategoryApplication.Get(id);
        }

        public RedirectToPageResult OnPost()
        {
            _articleCategoryApplication.Rename(ArticleCategory);
            return RedirectToPage("./List");
        }
    }
}
