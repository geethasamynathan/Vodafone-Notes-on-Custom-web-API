#pragma checksum "H:\Vodafone\Singleton_Transient_Scoped_Demo\Singleton_Transient_Scoped_Demo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "673e29725f7e896b6f00822e693def438135e1e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "H:\Vodafone\Singleton_Transient_Scoped_Demo\Singleton_Transient_Scoped_Demo\Views\_ViewImports.cshtml"
using Singleton_Transient_Scoped_Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Vodafone\Singleton_Transient_Scoped_Demo\Singleton_Transient_Scoped_Demo\Views\_ViewImports.cshtml"
using Singleton_Transient_Scoped_Demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"673e29725f7e896b6f00822e693def438135e1e3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfcb2d29e9b9173f376faf02cfa447e81f7a0367", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "H:\Vodafone\Singleton_Transient_Scoped_Demo\Singleton_Transient_Scoped_Demo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <table style=""border:1px;"">
        <tr>
            <th> Service typt</th>
            <th> First Instance ID</th>
            <th>Second Instance Id</th>
        </tr>

        <tr style=""background-color:aliceblue"">
            <td> Singleton</td>
            <td>");
#nullable restore
#line 15 "H:\Vodafone\Singleton_Transient_Scoped_Demo\Singleton_Transient_Scoped_Demo\Views\Home\Index.cshtml"
           Write(ViewBag.st1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "H:\Vodafone\Singleton_Transient_Scoped_Demo\Singleton_Transient_Scoped_Demo\Views\Home\Index.cshtml"
           Write(ViewBag.st2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr style=\"background-color: antiquewhite\">\r\n            <td> Transient</td>\r\n            <td>");
#nullable restore
#line 20 "H:\Vodafone\Singleton_Transient_Scoped_Demo\Singleton_Transient_Scoped_Demo\Views\Home\Index.cshtml"
           Write(ViewBag.t1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "H:\Vodafone\Singleton_Transient_Scoped_Demo\Singleton_Transient_Scoped_Demo\Views\Home\Index.cshtml"
           Write(ViewBag.t2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr style=\" background-color:aqua\">\r\n            <td> Scopped</td>\r\n            <td>");
#nullable restore
#line 25 "H:\Vodafone\Singleton_Transient_Scoped_Demo\Singleton_Transient_Scoped_Demo\Views\Home\Index.cshtml"
           Write(ViewBag.sc1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "H:\Vodafone\Singleton_Transient_Scoped_Demo\Singleton_Transient_Scoped_Demo\Views\Home\Index.cshtml"
           Write(ViewBag.sc2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n    </table>\r\n</div>\r\n");
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