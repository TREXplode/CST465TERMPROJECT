#pragma checksum "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "955e0d39d3eee92a2463ad2743fad6ae7efeaeb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Submission), @"mvc.1.0.view", @"/Views/Shared/Submission.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Submission.cshtml", typeof(AspNetCore.Views_Shared_Submission))]
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
#line 4 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\_ViewImports.cshtml"
using Lab4CST465.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"955e0d39d3eee92a2463ad2743fad6ae7efeaeb3", @"/Views/Shared/Submission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"849c2e6f30749d632ec8d0cef1d922c21458f45b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Submission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComputerModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
  
    ViewData["Title"] = "Submission";

#line default
#line hidden
            BeginContext(71, 115, true);
            WriteLiteral("\r\n<h2>Submission</h2>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(187, 10, false);
#line 11 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(197, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(212, 27, false);
#line 12 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Model.AdministratorPassword);

#line default
#line hidden
            EndContext();
            BeginContext(239, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(254, 15, false);
#line 13 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Model.IPAddress);

#line default
#line hidden
            EndContext();
            BeginContext(269, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(284, 14, false);
#line 14 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(298, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(313, 8, false);
#line 15 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Model.OS);

#line default
#line hidden
            EndContext();
            BeginContext(321, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(336, 23, false);
#line 16 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Model.SupportedMonitors);

#line default
#line hidden
            EndContext();
            BeginContext(359, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(374, 17, false);
#line 17 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(391, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(454, 32, false);
#line 20 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Html.DisplayFor(m => Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(486, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(501, 49, false);
#line 21 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Html.DisplayFor(m => Model.AdministratorPassword));

#line default
#line hidden
            EndContext();
            BeginContext(550, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(565, 37, false);
#line 22 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Html.DisplayFor(m => Model.IPAddress));

#line default
#line hidden
            EndContext();
            BeginContext(602, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(617, 36, false);
#line 23 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Html.DisplayFor(m => Model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(653, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(668, 30, false);
#line 24 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Html.DisplayFor(m => Model.OS));

#line default
#line hidden
            EndContext();
            BeginContext(698, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(713, 45, false);
#line 25 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Html.DisplayFor(m => Model.SupportedMonitors));

#line default
#line hidden
            EndContext();
            BeginContext(758, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(773, 39, false);
#line 26 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Html.DisplayFor(m => Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(812, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(875, 27, false);
#line 29 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\Submission.cshtml"
       Write(Html.DisplayForModel(Model));

#line default
#line hidden
            EndContext();
            BeginContext(902, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComputerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591