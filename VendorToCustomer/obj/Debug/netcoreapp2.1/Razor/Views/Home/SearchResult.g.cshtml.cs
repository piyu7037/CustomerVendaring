#pragma checksum "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\SearchResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ab0f23c4a2342fb083e1a7da6398008d965bf63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchResult), @"mvc.1.0.view", @"/Views/Home/SearchResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SearchResult.cshtml", typeof(AspNetCore.Views_Home_SearchResult))]
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
#line 1 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\_ViewImports.cshtml"
using VendorToCustomer;

#line default
#line hidden
#line 2 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\_ViewImports.cshtml"
using VendorToCustomer.Models;

#line default
#line hidden
#line 4 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ab0f23c4a2342fb083e1a7da6398008d965bf63", @"/Views/Home/SearchResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68d73acb721856e974382c2879e1c8da05c5f07", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VendorToCustomer.Models.Search>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\SearchResult.cshtml"
  
    ViewData["Title"] = "SearchResult";

#line default
#line hidden
            BeginContext(102, 253, true);
            WriteLiteral("\r\n<h2>Search Result</h2>\r\n\r\n<table class=\"table table-striped table-bordered table-hover\" style=\"background-color:bisque\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Customer Name\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(356, 40, false);
#line 16 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\SearchResult.cshtml"
           Write(Html.DisplayNameFor(model => model.Item));

#line default
#line hidden
            EndContext();
            BeginContext(396, 126, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Date of Purchase\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(523, 44, false);
#line 22 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\SearchResult.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(567, 167, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Price Per Unit\r\n            </th>\r\n            <th>Total Amount</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\SearchResult.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(783, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(844, 56, false);
#line 35 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\SearchResult.cshtml"
               Write(Html.DisplayFor(modelItem => item.Customer.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(900, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(968, 48, false);
#line 38 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\SearchResult.cshtml"
               Write(Html.DisplayFor(modelItem => item.Item.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1084, 49, false);
#line 41 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\SearchResult.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateOfPurchase));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1201, 43, false);
#line 44 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\SearchResult.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1312, 47, false);
#line 47 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\SearchResult.cshtml"
               Write(Html.DisplayFor(modelItem => item.PricePerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 49 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\SearchResult.cshtml"
                  var total = item.PricePerUnit * item.Quantity; 

#line default
#line hidden
            BeginContext(1452, 21, true);
            WriteLiteral("                <td> ");
            EndContext();
            BeginContext(1474, 35, false);
#line 50 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\SearchResult.cshtml"
                Write(Html.DisplayFor(modelItem => total));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(1835, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 57 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\SearchResult.cshtml"
        }

#line default
#line hidden
            BeginContext(1865, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VendorToCustomer.Models.Search>> Html { get; private set; }
    }
}
#pragma warning restore 1591
