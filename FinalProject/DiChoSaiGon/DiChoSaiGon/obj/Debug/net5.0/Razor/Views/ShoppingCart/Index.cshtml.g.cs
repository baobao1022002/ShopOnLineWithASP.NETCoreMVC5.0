#pragma checksum "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bb497942d50ec793ac692ee602abe8af56c36da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bb497942d50ec793ac692ee602abe8af56c36da", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469f34b858c23caba5aeee6f6c06385fbad72af1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DiChoSaiGon.ModelViews.CartItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Xem giỏ hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var returnUrl = Context.Request.Query["ReturnUrl"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""/assets/images/banner/2-1-1920x523.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">Giỏ hàng</h2>
                        <ul>
                            <li>
                                <a href=""/"">Trang chủ<i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>Giỏ hàng</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""cart-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
");
#nullable restore
#line 31 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                     if (Model != null && Model.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bb497942d50ec793ac692ee602abe8af56c36da5883", async() => {
                WriteLiteral(@"
                            <div class=""table-content table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th class=""product_remove"">Xóa</th>
                                            <th class=""product-thumbnail"">Ảnh đại diện</th>
                                            <th class=""cart-product-name"">Sản phẩm</th>
                                            <th class=""product-price"">Đơn giá</th>
                                            <th class=""product-quantity"">Số lượng</th>
                                            <th class=""product-subtotal"">Thành tiền</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 47 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                                         if (Model != null && Model.Count() > 0)
                                        {
                                            foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <tr>
                                                    <td class=""product_remove"">
                                                        <input type=""button"" value=""X"" class=""removecart btn btn-primary"" data-mahh=""");
#nullable restore
#line 53 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                                                                                                                                Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" />
                                                    </td>
                                                    <td class=""product-thumbnail"">
                                                        <a href=""javascript:void(0)"">
                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0bb497942d50ec793ac692ee602abe8af56c36da8480", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2997, "~/images/products/", 2997, 18, true);
#nullable restore
#line 57 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 3015, item.product.Thumb, 3015, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 57 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 3041, item.product.Title, 3041, 19, false);

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
                WriteLiteral("\r\n                                                        </a>\r\n                                                    </td>\r\n                                                    <td class=\"product-name\"><a href=\"javascript:void(0)\">");
#nullable restore
#line 60 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                                                                                                     Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                                    <td class=\"product-price\"><span class=\"amount\">");
#nullable restore
#line 61 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                                                                                              Write(item.product.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" VNĐ</span></td>
                                                    <td class=""quantity"">
                                                        <div class=""cart-plus-minus"">
                                                            <input data-mahh=""");
#nullable restore
#line 64 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                                                                         Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-dongia=\"");
#nullable restore
#line 64 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                                                                                                               Write(item.product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"cartItem cart-plus-minus-box\"");
                BeginWriteAttribute("value", " value=\"", 3822, "\"", 3842, 1);
#nullable restore
#line 64 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 3830, item.amount, 3830, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\" type=\"number\">\r\n                                                        </div>\r\n                                                    </td>\r\n                                                    <td class=\"product-subtotal\"><span class=\"amount\">");
#nullable restore
#line 67 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                                                                                                 Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</span></td>\r\n                                                </tr>\r\n");
#nullable restore
#line 69 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-5 ml-auto"">
                                    <div class=""cart-page-total"">
                                        <h2>Tổng đơn hàng</h2>
                                        <ul>
                                            <li>Thành tiền <span>");
#nullable restore
#line 79 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                                                            Write(Model.Sum(x => x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</span></li>\r\n                                        </ul>\r\n");
#nullable restore
#line 81 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                                         if (User.Identity.IsAuthenticated)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <a href=\"/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Thanh toán</a>\r\n");
#nullable restore
#line 84 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <a href=\"/dang-nhap.html?returnUrl=/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Thanh toán</a>\r\n");
#nullable restore
#line 88 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Chưa có hàng hóa trong giỏ hàng.Bạn hãy tích cực mua sắm đi nào</p>\r\n");
#nullable restore
#line 97 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\ShoppingCart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            function loadHeaderCart() {
                $('#miniCart').load(""/AjaxContent/HeaderCart"");
                $('#numberCart').load(""/AjaxContent/NumberCart"");
            }
            $("".removecart"").click(function () {
                var productid = $(this).attr(""data-mahh"");
                $.ajax({
                    url: ""api/cart/remove"",
                    type: ""POST"",
                    dataType: ""JSON"",
                    data: { productID: productid },
                    success: function (result) {
                        if (result.success) {
                            loadHeaderCart();//Reload lai gio hang
                            location.reload();
                        }
                    },
                    error: function (rs) {
                        alert(""Remove Cart Error !"")
                    }
                });
            });
            $("".cartItem"").click(function () {
                ");
                WriteLiteral(@"var productid = $(this).attr(""data-mahh"");
                var soluong = parseInt($(this).val());
                $.ajax({
                    url: ""api/cart/update"",
                    type: ""POST"",
                    dataType: ""JSON"",
                    data: {
                        productID: productid,
                        amount: soluong
                    },
                    success: function (result) {
                        if (result.success) {
                            loadHeaderCart();//Reload lai gio hang
                            window.location = 'cart.html';
                        }
                    },
                    error: function (rs) {
                        alert(""Cập nhật Cart Error !"")
                    }
                });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DiChoSaiGon.ModelViews.CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
