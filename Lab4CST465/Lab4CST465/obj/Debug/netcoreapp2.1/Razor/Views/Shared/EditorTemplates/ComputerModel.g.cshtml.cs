#pragma checksum "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\EditorTemplates\ComputerModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb3818b3510fb1a80f52a47a90c44a3d1f392b40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_ComputerModel), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/ComputerModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/EditorTemplates/ComputerModel.cshtml", typeof(AspNetCore.Views_Shared_EditorTemplates_ComputerModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3818b3510fb1a80f52a47a90c44a3d1f392b40", @"/Views/Shared/EditorTemplates/ComputerModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91b70d8bd42c43352c4bf0d26c55175878d31787", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_ComputerModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\EditorTemplates\ComputerModel.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 320, true);
            WriteLiteral(@"
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.15.1/jquery.validate.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.6/jquery.validate.unobtrusive.js""></script>


");
            EndContext();
#line 11 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\EditorTemplates\ComputerModel.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(425, 1059, true);
            WriteLiteral(@"    <div class=""form-group"">
        <label asp-for=""Name""></label>
        <input type=""text"" asp-for=""Name"" />
    </div>
    <div class=""form-group"">
        <label asp-for=""AdministratorPassword""></label>
        <input type=""text"" asp-for=""AdministratorPassword"" />
    </div>
    <div class=""form-group"">
        <label asp-for=""IPAddress""></label>
        <input type=""text"" asp-for=""IPAddress"" />
    </div>
    <div class=""form-group"">
        <label asp-for=""Location""></label>
        <input type=""text"" asp-for=""Location"" />
    </div>
    <div class=""form-group"">
        <label asp-for=""OS""></label>
        <input type=""text"" asp-for=""OS"" />
    </div>
    <div class=""form-group"">
        <label asp-for=""Description""></label>
        <input type=""text"" asp-for=""Label"" />
    </div>
    <div class=""form-group"">
        <label asp-for=""SupportedMonitors""></label>
        <input type=""text"" asp-for=""SupportedMonitors"" />
    </div>
    <div class=""form-group"">
        <label a");
            WriteLiteral("sp-for=\"OSTypes\"></label>\r\n        ");
            EndContext();
            BeginContext(1485, 110, false);
#line 43 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\EditorTemplates\ComputerModel.cshtml"
   Write(Html.DropDownList("OSTypes", new SelectList(ComputerModel.OSTypes), Model.OS, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 45 "D:\Old Stuff\College Stuff\TERM_FALL_2018\Assignments\Code\CST465TERMPROJECT\Lab4CST465\Lab4CST465\Views\Shared\EditorTemplates\ComputerModel.cshtml"
}

#line default
#line hidden
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
