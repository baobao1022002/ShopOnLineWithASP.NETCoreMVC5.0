#pragma checksum "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69f2fb95074a85d24ca16bd22c795e5fd41aff97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\_ViewImports.cshtml"
using DiChoSaiGon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\_ViewImports.cshtml"
using DiChoSaiGon.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69f2fb95074a85d24ca16bd22c795e5fd41aff97", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469f34b858c23caba5aeee6f6c06385fbad72af1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<DiChoSaiGon.Models.News>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Blog Index - " + ViewBag.CurrentPage;
    Layout = "~/Views/Shared/_Layout.cshtml";
    int PageCurrent = ViewBag.CurrentPage;
    int PageNext = PageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Begin Main Content Area -->
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""~/assets/images/breadcrumb/bg/1-1-1920x373.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">Tin n???i b???t</h2>
                        <ul>
                            <li>
                                <a href=""index.html"">Home <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>Tin n???i b???t</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""blog-area blog-column-2 section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
");
#nullable restore
#line 32 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
                 if(Model!=null && Model.Count()>0)
                {
                    foreach (var item in Model)
                    {
                        String url = $"/tin-tuc/{item.Alias}-{item.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6\">\r\n                            <div class=\"blog-item\">\r\n                                <div class=\"blog-img img-zoom-effect\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1655, "\"", 1666, 1);
#nullable restore
#line 40 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1662, url, 1662, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "69f2fb95074a85d24ca16bd22c795e5fd41aff976238", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1737, "~/images/news/", 1737, 14, true);
#nullable restore
#line 41 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1751, item.Thumb, 1751, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1769, item.Title, 1769, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </a>
                                </div>
                                <div class=""blog-content"">
                                    <div class=""blog-meta text-dim-gray pb-3"">
                                        <ul>
                                            <li class=""date""><i class=""fa fa-calendar-o me-2""></i>");
#nullable restore
#line 47 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
                                                                                             Write(item.CreatedDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                            <li>
                                                <span class=""comments me-3"">
                                                    <a href=""javascript:void(0)"">2 Comments</a>
                                                </span>
                                                <span class=""link-share"">
                                                    <a href=""javascript:void(0)"">Share</a>
                                                </span>
                                            </li>
                                        </ul>
                                    </div>
                                    <h5 class=""title mb-4"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2951, "\"", 2962, 1);
#nullable restore
#line 59 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2958, url, 2958, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </h5>\r\n                                    <p class=\"short-desc mb-5\">");
#nullable restore
#line 61 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
                                                          Write(item.Scontents);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"button-wrap\">\r\n                                        <a class=\"btn btn-custom-size lg-size btn-dark rounded-0\"");
            BeginWriteAttribute("href", " href=\"", 3268, "\"", 3279, 1);
#nullable restore
#line 63 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3275, url, 3275, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem th??m</a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 68 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            
   
                <div class=""col-lg-12"">

                    <div class=""pagination-area pt-10"">
                        <nav aria-label=""Page navigation example"">
                            <ul class=""pagination justify-content-center"">
");
#nullable restore
#line 77 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
                                 if(PageCurrent>1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3951, "\"", 3991, 2);
            WriteAttributeValue("", 3958, "/blogs.html?page=", 3958, 17, true);
#nullable restore
#line 80 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3975, PageCurrent-1, 3975, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                        <span class=\"fa fa-chevron-left\"></span>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 84 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class=""page-item"">
                                        <a class=""page-link"" href=""/blogs.html"" aria-label=""Previous"">
                                            <span class=""fa fa-chevron-left""></span>
                                        </a>
                                    </li>
");
#nullable restore
#line 92 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4743, "\"", 4783, 2);
            WriteAttributeValue("", 4750, "/blogs.html?page=", 4750, 17, true);
#nullable restore
#line 93 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4767, PageCurrent-1, 4767, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 93 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
                                                                                                                      Write(PageCurrent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4882, "\"", 4915, 2);
            WriteAttributeValue("", 4889, "/blogs.html?page=", 4889, 17, true);
#nullable restore
#line 94 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4906, PageNext, 4906, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 94 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
                                                                                                        Write(PageNext);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li class=\"page-item\">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5049, "\"", 5082, 2);
            WriteAttributeValue("", 5056, "/blogs.html?page=", 5056, 17, true);
#nullable restore
#line 96 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5073, PageNext, 5073, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Next"">
                                        <span class=""fa fa-chevron-right""></span>
                                    </a>
                                </li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>
<!-- Main Content Area End Here -->
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<DiChoSaiGon.Models.News>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
