#pragma checksum "C:\Users\Fancypants\Documents\BankOfBrabant\BankOfBrabant\BankOfBrabant\Views\Rekening\geefweer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8461343bc8916f0a7f2171d01b253c09c28d19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rekening_geefweer), @"mvc.1.0.view", @"/Views/Rekening/geefweer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rekening/geefweer.cshtml", typeof(AspNetCore.Views_Rekening_geefweer))]
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
#line 1 "C:\Users\Fancypants\Documents\BankOfBrabant\BankOfBrabant\BankOfBrabant\Views\_ViewImports.cshtml"
using BankOfBrabant;

#line default
#line hidden
#line 2 "C:\Users\Fancypants\Documents\BankOfBrabant\BankOfBrabant\BankOfBrabant\Views\_ViewImports.cshtml"
using BankOfBrabant.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8461343bc8916f0a7f2171d01b253c09c28d19", @"/Views/Rekening/geefweer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d7af32f13cb11ee714d06a0b47e1580b2ddc190", @"/Views/_ViewImports.cshtml")]
    public class Views_Rekening_geefweer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Fancypants\Documents\BankOfBrabant\BankOfBrabant\BankOfBrabant\Views\Rekening\geefweer.cshtml"
  
    ViewData["Title"] = "Rekening Informatie";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(104, 32, true);
            WriteLiteral("\r\n<h2>Rekening Informatie</h2>\r\n");
            EndContext();
            BeginContext(137, 16, false);
#line 8 "C:\Users\Fancypants\Documents\BankOfBrabant\BankOfBrabant\BankOfBrabant\Views\Rekening\geefweer.cshtml"
Write(ViewBag.Rekening);

#line default
#line hidden
            EndContext();
            BeginContext(153, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
