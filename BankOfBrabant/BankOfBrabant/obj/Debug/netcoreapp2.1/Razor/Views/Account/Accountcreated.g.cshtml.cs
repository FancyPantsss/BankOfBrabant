#pragma checksum "C:\Users\Dave\MyDocuments\bankofbrabant\BankOfBrabant\BankOfBrabant\Views\Account\Accountcreated.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1060093ef8816e41552a7fca3dc7025249b9edb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Accountcreated), @"mvc.1.0.view", @"/Views/Account/Accountcreated.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Accountcreated.cshtml", typeof(AspNetCore.Views_Account_Accountcreated))]
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
#line 1 "C:\Users\Dave\MyDocuments\bankofbrabant\BankOfBrabant\BankOfBrabant\Views\_ViewImports.cshtml"
using BankOfBrabant;

#line default
#line hidden
#line 2 "C:\Users\Dave\MyDocuments\bankofbrabant\BankOfBrabant\BankOfBrabant\Views\_ViewImports.cshtml"
using BankOfBrabant.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1060093ef8816e41552a7fca3dc7025249b9edb", @"/Views/Account/Accountcreated.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d7af32f13cb11ee714d06a0b47e1580b2ddc190", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Accountcreated : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankOfBrabant.Models.AccountAbstract>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dave\MyDocuments\bankofbrabant\BankOfBrabant\BankOfBrabant\Views\Account\Accountcreated.cshtml"
  
    ViewData["Title"] = "Accountcreated";

#line default
#line hidden
            BeginContext(97, 136, true);
            WriteLiteral("\r\n<h2>Accountcreated</h2>\r\n\r\n<div>\r\n    <h4>AccountAbstract</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(234, 46, false);
#line 14 "C:\Users\Dave\MyDocuments\bankofbrabant\BankOfBrabant\BankOfBrabant\Views\Account\Accountcreated.cshtml"
       Write(Html.DisplayNameFor(model => model.PassNumber));

#line default
#line hidden
            EndContext();
            BeginContext(280, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(324, 42, false);
#line 17 "C:\Users\Dave\MyDocuments\bankofbrabant\BankOfBrabant\BankOfBrabant\Views\Account\Accountcreated.cshtml"
       Write(Html.DisplayFor(model => model.PassNumber));

#line default
#line hidden
            EndContext();
            BeginContext(366, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(414, 68, false);
#line 22 "C:\Users\Dave\MyDocuments\bankofbrabant\BankOfBrabant\BankOfBrabant\Views\Account\Accountcreated.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(482, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(490, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df42833187d24875ae9c9db07b4548e6", async() => {
                BeginContext(512, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(528, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(539, 15, false);
#line 25 "C:\Users\Dave\MyDocuments\bankofbrabant\BankOfBrabant\BankOfBrabant\Views\Account\Accountcreated.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(554, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankOfBrabant.Models.AccountAbstract> Html { get; private set; }
    }
}
#pragma warning restore 1591
