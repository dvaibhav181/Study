#pragma checksum "C:\Vaibhav\Study\source\Exercises\DemoCoreMVC\Views\Products\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a51452ac8bb0398061d181657c82fad1d532a429"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Product), @"mvc.1.0.view", @"/Views/Products/Product.cshtml")]
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
#line 1 "C:\Vaibhav\Study\source\Exercises\DemoCoreMVC\Views\_ViewImports.cshtml"
using DemoCoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Vaibhav\Study\source\Exercises\DemoCoreMVC\Views\_ViewImports.cshtml"
using DemoCoreMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51452ac8bb0398061d181657c82fad1d532a429", @"/Views/Products/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde9bcea4bdc8b4c092fe5d25fcb2fe592abf468", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Vaibhav\Study\source\Exercises\DemoCoreMVC\Views\Products\Product.cshtml"
    
    var item = ViewBag.Product;  

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>  \r\n    <tr>  \r\n    <th> Id </th> <th> Name </th>  \r\n    <td> ");
#nullable restore
#line 7 "C:\Vaibhav\Study\source\Exercises\DemoCoreMVC\Views\Products\Product.cshtml"
    Write(item._productId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td> <td> ");
#nullable restore
#line 7 "C:\Vaibhav\Study\source\Exercises\DemoCoreMVC\Views\Products\Product.cshtml"
                                Write(item._name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td></tr>   \r\n</table>  \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
