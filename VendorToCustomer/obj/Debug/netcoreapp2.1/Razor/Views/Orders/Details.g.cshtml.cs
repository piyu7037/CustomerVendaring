#pragma checksum "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dc43ccac41a7b034a44d08b1ca629d70283c97e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Details.cshtml", typeof(AspNetCore.Views_Orders_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dc43ccac41a7b034a44d08b1ca629d70283c97e", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68d73acb721856e974382c2879e1c8da05c5f07", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VendorToCustomer.Models.Orders>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Orders\Details.cshtml"
  
        ViewData["Title"] = "Details";
    

#line default
#line hidden
            BeginContext(105, 22, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n");
            EndContext();
#line 9 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Orders\Details.cshtml"
 foreach (var item in Model)
{
        

#line default
#line hidden
            BeginContext(169, 31, false);
#line 11 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Orders\Details.cshtml"
   Write(Html.Partial("ViewOrders",item));

#line default
#line hidden
            EndContext();
#line 11 "D:\backup\CustomerVendoring2(pagination)\VendorToCustomer\Views\Orders\Details.cshtml"
                                        
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VendorToCustomer.Models.Orders>> Html { get; private set; }
    }
}
#pragma warning restore 1591