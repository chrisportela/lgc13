#pragma checksum "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50a99a7635b7f06106a135a25ad0709b0fbb5636"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lucas_Index), @"mvc.1.0.view", @"/Views/Lucas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lucas/Index.cshtml", typeof(AspNetCore.Views_Lucas_Index))]
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
#line 1 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/_ViewImports.cshtml"
using LucasHelloWorldMVC;

#line default
#line hidden
#line 2 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/_ViewImports.cshtml"
using LucasHelloWorldMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50a99a7635b7f06106a135a25ad0709b0fbb5636", @"/Views/Lucas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2d19e15305489f26582a7e13ccf516ddce506fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Lucas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Lucas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "New", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Index.cshtml"
  
    ViewData["Title"] = "My Hello World Project";
    

#line default
#line hidden
            BeginContext(152, 114, true);
            WriteLiteral("\n<h1> Hello World, from Lucas\'s index Page </h1>\n\n<p> List of cheeses made and iterated in Index.cshtml </p>\n<ul>\n");
            EndContext();
#line 12 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Index.cshtml"
   foreach (string item in ViewBag.cheeses)
  {

#line default
#line hidden
            BeginContext(314, 9, true);
            WriteLiteral("    <li> ");
            EndContext();
            BeginContext(324, 4, false);
#line 14 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Index.cshtml"
    Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(328, 7, true);
            WriteLiteral(" </li>\n");
            EndContext();
#line 15 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(339, 16, true);
            WriteLiteral("\n</ul>\n\n<p>\n    ");
            EndContext();
            BeginContext(355, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69f36025ffb840338a576abdd2e62f40", async() => {
                BeginContext(398, 17, true);
                WriteLiteral("Link to add users");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(419, 6, true);
            WriteLiteral("\n</p>\n");
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
