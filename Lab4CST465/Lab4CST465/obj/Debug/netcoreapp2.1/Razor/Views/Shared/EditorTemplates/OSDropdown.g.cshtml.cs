#pragma checksum "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\EditorTemplates\OSDropdown.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cd9499ac2f7fd56fe45cbcb0676364cf1281a0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_OSDropdown), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/OSDropdown.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/EditorTemplates/OSDropdown.cshtml", typeof(AspNetCore.Views_Shared_EditorTemplates_OSDropdown))]
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
#line 1 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\_ViewImports.cshtml"
using Lab4CST465.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd9499ac2f7fd56fe45cbcb0676364cf1281a0b", @"/Views/Shared/EditorTemplates/OSDropdown.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91b70d8bd42c43352c4bf0d26c55175878d31787", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_OSDropdown : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\EditorTemplates\OSDropdown.cshtml"
  
    ViewData["Title"] = "OSDropdown";

#line default
#line hidden
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 103, false);
#line 6 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\EditorTemplates\OSDropdown.cshtml"
Write(Html.DropDownListFor(model=>model, new SelectList(ComputerModel.OSTypes), new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(167, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
