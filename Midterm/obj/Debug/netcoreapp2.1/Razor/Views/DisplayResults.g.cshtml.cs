#pragma checksum "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Midterm\Views\DisplayResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29477ce0c3b813cf74f2d75c85aaf9954c273c9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DisplayResults), @"mvc.1.0.view", @"/Views/DisplayResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DisplayResults.cshtml", typeof(AspNetCore.Views_DisplayResults))]
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
#line 3 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Midterm\Views\_ViewImports.cshtml"
using Midterm.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29477ce0c3b813cf74f2d75c85aaf9954c273c9d", @"/Views/DisplayResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790c83351583a7d6c3486798240968b106108f99", @"/Views/_ViewImports.cshtml")]
    public class Views_DisplayResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestQuestion>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Midterm\Views\DisplayResults.cshtml"
  
    ViewData["Title"] = "DisplayResults";

#line default
#line hidden
            BeginContext(84, 140, true);
            WriteLiteral("\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <td>Question</td>\r\n            <td>Answer</td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 14 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Midterm\Views\DisplayResults.cshtml"
         foreach(var t in Model)
        {

#line default
#line hidden
            BeginContext(269, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(308, 10, false);
#line 17 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Midterm\Views\DisplayResults.cshtml"
               Write(t.Question);

#line default
#line hidden
            EndContext();
            BeginContext(318, 64, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(383, 8, false);
#line 20 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Midterm\Views\DisplayResults.cshtml"
               Write(t.Answer);

#line default
#line hidden
            EndContext();
            BeginContext(391, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 22 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Midterm\Views\DisplayResults.cshtml"
        }

#line default
#line hidden
            BeginContext(428, 33, true);
            WriteLiteral("    </tbody>foreach\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestQuestion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
