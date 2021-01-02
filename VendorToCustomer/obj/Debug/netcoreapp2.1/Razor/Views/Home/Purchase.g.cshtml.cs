#pragma checksum "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\Purchase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "374f69a0a815406971db891ef66ff0a3ac6cbb9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Purchase), @"mvc.1.0.view", @"/Views/Home/Purchase.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Purchase.cshtml", typeof(AspNetCore.Views_Home_Purchase))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"374f69a0a815406971db891ef66ff0a3ac6cbb9c", @"/Views/Home/Purchase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68d73acb721856e974382c2879e1c8da05c5f07", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Purchase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VendorToCustomer.Models.Purchase>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPurchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\Purchase.cshtml"
  
    ViewData["Title"] = "Purchase";

#line default
#line hidden
            BeginContext(100, 515, true);
            WriteLiteral(@"
<h2>Purchase Transaction</h2>
<table class=""table table-striped table-bordered table-hover"" style=""background-color:bisque"">
    <thead>
        <tr>
            <th>
                Vendor Name
            </th>
            <th>
                Item Name
            </th>
            <th>
                Date Of Purchase
            </th>
            <th>
                Price
            </th>
            <th>
                Quantity
            </th>
            <th>Total Amount</th>
");
            EndContext();
            BeginContext(644, 42, true);
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\Purchase.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(735, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(796, 54, false);
#line 35 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\Purchase.cshtml"
               Write(Html.DisplayFor(modelItem => item.Vendors.VendorsName));

#line default
#line hidden
            EndContext();
            BeginContext(850, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(918, 48, false);
#line 38 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\Purchase.cshtml"
               Write(Html.DisplayFor(modelItem => item.Item.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(966, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1034, 49, false);
#line 41 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\Purchase.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateOfPurchase));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1151, 40, false);
#line 44 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\Purchase.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1259, 43, false);
#line 47 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\Purchase.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 49 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\Purchase.cshtml"
                  var Total = item.Quantity * item.Price;

#line default
#line hidden
            BeginContext(1387, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1430, 35, false);
#line 51 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\Purchase.cshtml"
               Write(Html.DisplayFor(modelItem => Total));

#line default
#line hidden
            EndContext();
            BeginContext(1465, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(1818, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 59 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Home\Purchase.cshtml"
        }

#line default
#line hidden
            BeginContext(1848, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1968, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(1979, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1af6b154fd90471b9ee4fded0d6c83cc", async() => {
                BeginContext(2023, 17, true);
                WriteLiteral("Back to Home Page");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2044, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2050, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c16e430a47d444b95746fd4e10b5838", async() => {
                BeginContext(2100, 12, true);
                WriteLiteral("Add Purchase");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2116, 10, true);
            WriteLiteral("\r\n\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VendorToCustomer.Models.Purchase>> Html { get; private set; }
    }
}
#pragma warning restore 1591
