#pragma checksum "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e26d2013e81d6142bdc3d4ed19f8f159f11af86b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminCategories_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminCategories/Delete.cshtml")]
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
#line 1 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\_ViewImports.cshtml"
using DiChoSaiGon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\_ViewImports.cshtml"
using DiChoSaiGon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e26d2013e81d6142bdc3d4ed19f8f159f11af86b", @"/Areas/Admin/Views/AdminCategories/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469f34b858c23caba5aeee6f6c06385fbad72af1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminCategories_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DiChoSaiGon.Models.Category>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminCategories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
  
    ViewData["Title"] = "Xóa nhận xóa danh mục: " + Model.CatName;
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"page-header\">\r\n\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e26d2013e81d6142bdc3d4ed19f8f159f11af86b7273", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e26d2013e81d6142bdc3d4ed19f8f159f11af86b8971", async() => {
                WriteLiteral("Danh sách danh mục");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span class=\"breadcrumb-item active\">: ");
#nullable restore
#line 16 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                              Write(Model.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
        </nav>
    </div>
</div>

<div class=""page-header no-gutters has-tab"">
    <div class=""d-md-flex m-b-15 align-items-center justify-content-between"">
        <div class=""media align-items-center m-b-15"">
            <div class=""avatar avatar-image rounded"" style=""height:70px;width:70px"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e26d2013e81d6142bdc3d4ed19f8f159f11af86b11330", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 984, "~/images/category/", 984, 18, true);
#nullable restore
#line 25 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
AddHtmlAttributeValue("", 1002, Model.Thumb, 1002, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
AddHtmlAttributeValue("", 1021, Model.Title, 1021, 12, false);

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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"m-l-15\">\r\n                <h4 class=\"m-b-0\">");
#nullable restore
#line 28 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                             Write(Model.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            </div>
        </div>
    
    </div>
    <ul class=""nav nav-tabs"">
        <li class=""nav-item"">
            <a class=""nav-link active"" data-toggle=""tab"" href=""#product-overview"">OverView</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#product-images"">Ảnh đại diện</a>
        </li>
    </ul>
</div>
<div class=""container-fluid"">
    <div class=""tab-content m-t-15"">
        <div class=""tab-pane fade show active"" id=""product-overview"">
            <div class=""card"">
                <div class=""card-body"">
                    <h1 class=""card-title"">XÁC NHẬN XÓA  : ");
#nullable restore
#line 47 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                      Write(Model.CatName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n                    <div class=\"table-responsive\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e26d2013e81d6142bdc3d4ed19f8f159f11af86b14877", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e26d2013e81d6142bdc3d4ed19f8f159f11af86b15164", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 51 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CatId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <table class=""product-info-table m-t-20"">
                                <tbody>
                                    <tr>
                                        <td>Tên sản phẩm:</td>
                                        <td class=""text-dark font-weight-semibold"">");
#nullable restore
#line 56 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                                              Write(Model.CatName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>Alias:</td>\r\n                                        <td>");
#nullable restore
#line 60 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                       Write(Model.Alias);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                    </tr>
                                    <tr>
                                        <td>Trạng Thái:</td>
                                        <td>
                                            <div class=""checkbox"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e26d2013e81d6142bdc3d4ed19f8f159f11af86b18386", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 66 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Published);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                <label for=""Published"">Public</label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class=""col-sm-2"">
                                                 ");
#nullable restore
#line 73 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                            Write(Html.DisplayNameFor(model => model.Ordering));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"col-sm-10\">\r\n                                                            ");
#nullable restore
#line 76 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                       Write(Html.DisplayFor(model => model.Ordering));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </td>
                                     </tr>
                                     <tr>
                                        <td class=""col-sm-2"">
                                                            ");
#nullable restore
#line 81 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.Thumb));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"col-sm-10\">\r\n                                                            ");
#nullable restore
#line 84 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                       Write(Html.DisplayFor(model => model.Thumb));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class=""col-sm-2"">
                                                            ");
#nullable restore
#line 89 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"col-sm-10\">\r\n                                                            ");
#nullable restore
#line 92 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class=""col-sm-2"">
                                                            ");
#nullable restore
#line 97 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.Alias));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"col-sm-10\">\r\n                                                            ");
#nullable restore
#line 100 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                       Write(Html.DisplayFor(model => model.Alias));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class=""col-sm-2"">
                                                            ");
#nullable restore
#line 105 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.MetaDesc));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"col-sm-10\">\r\n                                                            ");
#nullable restore
#line 108 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                       Write(Html.DisplayFor(model => model.MetaDesc));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class=""col-sm-2"">
                                                            ");
#nullable restore
#line 113 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.MetaKey));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"col-sm-10\">\r\n                                                            ");
#nullable restore
#line 116 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                       Write(Html.DisplayFor(model => model.MetaKey));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>Xác nhận xóa sản phẩm:</td>
                                        <td>
                                            <input type=""submit"" value=""Xác nhận xóa"" class=""btn btn-danger"" />
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
                                                    WriteLiteral(Model.CatId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"">
                    <h4 class=""card-title"">THÔNG TIN MÔ TẢ</h4>
                </div>
                <div class=""card-body"">
                    ");
#nullable restore
#line 138 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
               Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""tab-pane fade"" id=""product-images"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e26d2013e81d6142bdc3d4ed19f8f159f11af86b30813", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7356, "~/images/category/", 7356, 18, true);
#nullable restore
#line 147 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
AddHtmlAttributeValue("", 7374, Model.Thumb, 7374, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 147 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Areas\Admin\Views\AdminCategories\Delete.cshtml"
AddHtmlAttributeValue("", 7393, Model.Title, 7393, 12, false);

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
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n         \r\n           ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DiChoSaiGon.Models.Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591