#pragma checksum "D:\Projects\ASPNetCore\MasterBlog\MasterBlog\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27590c617ea7e133d5580077909b3bb04067701b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MB.Presentation.MVCCore.Pages.Pages_ArticleDetails), @"mvc.1.0.razor-page", @"/Pages/ArticleDetails.cshtml")]
namespace MB.Presentation.MVCCore.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Id:long}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27590c617ea7e133d5580077909b3bb04067701b", @"/Pages/ArticleDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff777bbf70474f80581643d8b2fd7fe4e1f06fbf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ArticleDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Projects\ASPNetCore\MasterBlog\MasterBlog\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
  
    ViewData["Title"] = "ArticleDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<main class=\"post blog-post col-lg-12\">\r\n    <div class=\"container\">\r\n        <div class=\"post-single\">\r\n            <div class=\"post-thumbnail\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 268, "\"", 294, 1);
#nullable restore
#line 12 "D:\Projects\ASPNetCore\MasterBlog\MasterBlog\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 274, Model.Article.Image, 274, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 295, "\"", 321, 1);
#nullable restore
#line 12 "D:\Projects\ASPNetCore\MasterBlog\MasterBlog\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 301, Model.Article.Title, 301, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 322, "\"", 350, 1);
#nullable restore
#line 12 "D:\Projects\ASPNetCore\MasterBlog\MasterBlog\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 330, Model.Article.Title, 330, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n            </div>\r\n            <div class=\"post-details\">\r\n                <div class=\"post-meta d-flex justify-content-between\">\r\n                    <div class=\"category\">\r\n                        <a href=\"#\">");
#nullable restore
#line 17 "D:\Projects\ASPNetCore\MasterBlog\MasterBlog\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
                               Write(Model.Article.ArticleCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n                <h1>\r\n                    ");
#nullable restore
#line 21 "D:\Projects\ASPNetCore\MasterBlog\MasterBlog\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
               Write(Model.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <a href=""#"">
                        <i class=""fa fa-bookmark-o""></i>
                    </a>
                </h1>
                <div class=""post-footer d-flex align-items-center flex-column flex-sm-row"">
                    <div class=""d-flex align-items-center flex-wrap"">
                        <div class=""date"">
                            <i class=""icon-clock""></i> ");
#nullable restore
#line 29 "D:\Projects\ASPNetCore\MasterBlog\MasterBlog\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
                                                  Write(Model.Article.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <div class=""comments meta-last""><i class=""icon-comment""></i>12</div>
                    </div>
                </div>
                <div class=""post-body"">
                    <p>
                        ");
#nullable restore
#line 36 "D:\Projects\ASPNetCore\MasterBlog\MasterBlog\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
                   Write(Model.Article.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    ");
#nullable restore
#line 38 "D:\Projects\ASPNetCore\MasterBlog\MasterBlog\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
               Write(Model.Article.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</main>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticleDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ArticleDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ArticleDetailsModel>)PageContext?.ViewData;
        public ArticleDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
