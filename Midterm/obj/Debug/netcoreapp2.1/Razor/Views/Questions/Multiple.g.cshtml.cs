#pragma checksum "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Midterm\Views\Questions\Multiple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5189e0709e6c807f9907f30b1d0bb750cf961316"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Multiple), @"mvc.1.0.view", @"/Views/Questions/Multiple.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questions/Multiple.cshtml", typeof(AspNetCore.Views_Questions_Multiple))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5189e0709e6c807f9907f30b1d0bb750cf961316", @"/Views/Questions/Multiple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790c83351583a7d6c3486798240968b106108f99", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Multiple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MultipleChoiceQuestion>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 30, true);
            WriteLiteral("\r\n<tr>\r\n    <td>\r\n        <h2>");
            EndContext();
            BeginContext(62, 14, false);
#line 5 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Midterm\Views\Questions\Multiple.cshtml"
       Write(Model.Question);

#line default
#line hidden
            EndContext();
            BeginContext(76, 47, true);
            WriteLiteral("</h2>\r\n    </td>\r\n    <td class=\"form-group\">\r\n");
            EndContext();
#line 8 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Midterm\Views\Questions\Multiple.cshtml"
         foreach (var choice in Model.Choice)
        {

#line default
#line hidden
            BeginContext(181, 57, true);
            WriteLiteral("            <input type=\"radio\" name=\"Answer\" id=\"Answer\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 238, "\"", 253, 1);
#line 10 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Midterm\Views\Questions\Multiple.cshtml"
WriteAttributeValue("", 246, choice, 246, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(254, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 11 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Midterm\Views\Questions\Multiple.cshtml"
        }

#line default
#line hidden
            BeginContext(270, 23, true);
            WriteLiteral("    </td>foreach\r\n</tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MultipleChoiceQuestion> Html { get; private set; }
    }
}
#pragma warning restore 1591