#pragma checksum "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Assignment2\Views\Shared\_DefaultLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c4a9c9830ce3471f48800de6aea8db18ac90d25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DefaultLayout), @"mvc.1.0.view", @"/Views/Shared/_DefaultLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_DefaultLayout.cshtml", typeof(AspNetCore.Views_Shared__DefaultLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c4a9c9830ce3471f48800de6aea8db18ac90d25", @"/Views/Shared/_DefaultLayout.cshtml")]
    public class Views_Shared__DefaultLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("Stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DefaultStyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 542, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7be2c0bc4f86416483176486ac1827d8", async() => {
                BeginContext(31, 455, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO""
          crossorigin=""anonymous"">
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy""
            crossorigin=""anonymous""></script>
    ");
                EndContext();
                BeginContext(486, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "68b7ebbbe28a4228984e84beb79cd35b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(558, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(567, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(569, 1303, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e27eec51eaa40bfb8bebf9ea0856687", async() => {
                BeginContext(575, 181, true);
                WriteLiteral("\r\n    <h2 id=\"SiteName\">MySite</h2>\r\n    <div>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm\" id=\"links\">\r\n                    ");
                EndContext();
                BeginContext(757, 40, false);
#line 16 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Assignment2\Views\Shared\_DefaultLayout.cshtml"
               Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(797, 70, true);
                WriteLiteral("\r\n                    <a href=\"/Home/Index\"></a>\r\n                    ");
                EndContext();
                BeginContext(868, 42, false);
#line 18 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Assignment2\Views\Shared\_DefaultLayout.cshtml"
               Write(Html.ActionLink("About", "Index", "About"));

#line default
#line hidden
                EndContext();
                BeginContext(910, 65, true);
                WriteLiteral("\r\n                    <a href=\"/About\"></a>\r\n                    ");
                EndContext();
                BeginContext(976, 46, false);
#line 20 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Assignment2\Views\Shared\_DefaultLayout.cshtml"
               Write(Html.ActionLink("Contact", "Index", "Contact"));

#line default
#line hidden
                EndContext();
                BeginContext(1022, 637, true);
                WriteLiteral(@"
                    <a href=""/Contact""></a>
                </div>
                <div class=""col-sm"" id=""Content1"">
                    <p>Content</p>
                </div>
            </div>
            <div class=""row"" id=""Content2"">
                <p>Some more Content</p>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""row"" id=""Content3"">
            <div class=""col-sm"">
                <header>Even More Content</header>
            </div>
        </div>
        <main>
            <div class=""row"">
                <div class=""col-sm-9"">
                    ");
                EndContext();
                BeginContext(1660, 12, false);
#line 41 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Assignment2\Views\Shared\_DefaultLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1672, 86, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    ");
                EndContext();
                BeginContext(1759, 31, false);
#line 44 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Assignment2\Views\Shared\_DefaultLayout.cshtml"
               Write(RenderSection("Sidebar", false));

#line default
#line hidden
                EndContext();
                BeginContext(1790, 75, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </main>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1872, 9, true);
            WriteLiteral("\r\n</html>");
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
