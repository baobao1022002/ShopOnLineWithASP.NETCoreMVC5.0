#pragma checksum "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Accounts\_DonhangPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2267854979d8b1f52892b9a82ec94425bfe4572f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts__DonhangPartialView), @"mvc.1.0.view", @"/Views/Accounts/_DonhangPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2267854979d8b1f52892b9a82ec94425bfe4572f", @"/Views/Accounts/_DonhangPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469f34b858c23caba5aeee6f6c06385fbad72af1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Accounts__DonhangPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Accounts\_DonhangPartialView.cshtml"
 if(Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive"">
        <table class=""table table-bordered table-hover"">
            <tbody>
                <tr>
                    <th>ID</th>
                    <th>Ng??y mua h??ng</th>
                    <th>Ng??y Ship h??ng</th>
                    <th>Tr???ng th??i</th>
                    <th>T???ng ti???n</th>
                    <th></th>
                </tr>
");
#nullable restore
#line 15 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Accounts\_DonhangPartialView.cshtml"
                 foreach(var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><a class=\"account-order-id\" href=\"javascript:void(0)\">#");
#nullable restore
#line 18 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Accounts\_DonhangPartialView.cshtml"
                                                                              Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                        <td>");
#nullable restore
#line 19 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Accounts\_DonhangPartialView.cshtml"
                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 20 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Accounts\_DonhangPartialView.cshtml"
                       Write(item.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 21 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Accounts\_DonhangPartialView.cshtml"
                       Write(item.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Accounts\_DonhangPartialView.cshtml"
                       Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VN??</td>\r\n                        <td>\r\n                            <a href=\"javascript:void(0)\" class=\"btn btn-secondary btn-primary-hover\"><span>Xem ????n H??ng</span></a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Accounts\_DonhangPartialView.cshtml"
                }             

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 31 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Accounts\_DonhangPartialView.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Ch??a c?? ????n h??ng.</p>\r\n");
#nullable restore
#line 35 "C:\Users\Admin\Documents\.NET\FinalProject\FinalProject\DiChoSaiGon\DiChoSaiGon\Views\Accounts\_DonhangPartialView.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
