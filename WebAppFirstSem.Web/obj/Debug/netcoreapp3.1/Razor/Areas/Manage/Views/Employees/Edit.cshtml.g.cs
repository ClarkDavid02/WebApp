#pragma checksum "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62da346d640ef00142ece569bd33f4d92f9c223b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Employees_Edit), @"mvc.1.0.view", @"/Areas/Manage/Views/Employees/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62da346d640ef00142ece569bd33f4d92f9c223b", @"/Areas/Manage/Views/Employees/Edit.cshtml")]
    public class Areas_Manage_Views_Employees_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppFirstSem.Web.Areas.Manage.ViewModels.Employees.EditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/employees/edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
  
    Layout = "~/areas/manage/views/shared/_managelayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62da346d640ef00142ece569bd33f4d92f9c223b4160", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 13 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 14 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 442, "\"", 459, 1);
#nullable restore
#line 15 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
WriteAttributeValue("", 450, Model.Id, 450, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"EmployeeStatus\" class=\"control-label mb-1\">Employee Status </label>\r\n                    <select class=\"form-control\" id=\"EmployeeStatus\" name=\"EmployeeStatus\">\r\n");
#nullable restore
#line 20 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
                          
                            var options = Enum.GetValues(typeof(WebAppFirstSem.Web.Infrastructures.Domain.Enums.EmployeeStatus)).Cast<WebAppFirstSem.Web.Infrastructures.Domain.Enums.EmployeeStatus>();

                            foreach (WebAppFirstSem.Web.Infrastructures.Domain.Enums.EmployeeStatus option in options)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <option");
                BeginWriteAttribute("value", " value=\"", 1125, "\"", 1140, 1);
#nullable restore
#line 25 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
WriteAttributeValue("", 1133, option, 1133, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
                                                   Write(option.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 26 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
                <div class=""form-group"">
                    <label for=""FirstName"" class=""control-label mb-2"">FirstName</label>
                    <input type=""text"" class=""form-control"" id=""FirstName"" name=""FirstName"" aria-describedby=""nameHelp""");
                BeginWriteAttribute("value", " value=\"", 1534, "\"", 1558, 1);
#nullable restore
#line 32 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
WriteAttributeValue("", 1542, Model.FirstName, 1542, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter FirstName"">
                </div>
                <div class=""form-group"">
                    <label for=""LastName"" class=""control-label mb-2"">LastName</label>
                    <input type=""text"" class=""form-control"" id=""LastName"" name=""LastName"" aria-describedby=""nameHelp""");
                BeginWriteAttribute("value", " value=\"", 1862, "\"", 1885, 1);
#nullable restore
#line 36 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
WriteAttributeValue("", 1870, Model.LastName, 1870, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter LastName"">
                </div>
                <div class=""form-group"">
                    <label for=""UserName"" class=""control-label mb-2"">UserName</label>
                    <input type=""text"" class=""form-control"" id=""UserName"" name=""UserName"" aria-describedby=""nameHelp""");
                BeginWriteAttribute("value", " value=\"", 2188, "\"", 2211, 1);
#nullable restore
#line 40 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
WriteAttributeValue("", 2196, Model.UserName, 2196, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter UserName"">
                </div>
                <div class=""form-group"">
                    <label for=""Address"" class=""control-label mb-2"">Address</label>
                    <input type=""text"" class=""form-control"" id=""Address"" name=""Address"" aria-describedby=""nameHelp""");
                BeginWriteAttribute("value", " value=\"", 2510, "\"", 2532, 1);
#nullable restore
#line 44 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
WriteAttributeValue("", 2518, Model.Address, 2518, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter Address"">
                </div>
                <div class=""form-group"">
                    <label for=""PhoneNumber"" class=""control-label mb-2"">PhoneNumber</label>
                    <input type=""text"" class=""form-control"" id=""PhoneNumber"" name=""PhoneNumber"" aria-describedby=""nameHelp""");
                BeginWriteAttribute("value", " value=\"", 2846, "\"", 2872, 1);
#nullable restore
#line 48 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
WriteAttributeValue("", 2854, Model.PhoneNumber, 2854, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter PhoneNumber"">
                </div>
                <div class=""form-group"">
                    <label for=""EmailAddress"" class=""control-label mb-2"">EmailAddress</label>
                    <input type=""email"" class=""form-control"" id=""EmailAddress"" name=""EmailAddress"" aria-describedby=""nameHelp""");
                BeginWriteAttribute("value", " value=\"", 3195, "\"", 3222, 1);
#nullable restore
#line 52 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
WriteAttributeValue("", 3203, Model.EmailAddress, 3203, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Enter EmailAddress"">
                </div>

                <div class=""form-group"">
                    <label for=""Password"" class=""control-label mb-2"">Password</label>
                    <input type=""password"" class=""form-control"" id=""Password"" name=""Password"" aria-describedby=""descriptionHelp""");
                BeginWriteAttribute("value", " value=\"", 3542, "\"", 3565, 1);
#nullable restore
#line 57 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
WriteAttributeValue("", 3550, Model.Password, 3550, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Password\">\r\n                </div>\r\n\r\n\r\n\r\n                <div class=\"mt-2\">\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62da346d640ef00142ece569bd33f4d92f9c223b12728", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3776, "~/manage/employees/details/", 3776, 27, true);
#nullable restore
#line 64 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Edit.cshtml"
AddHtmlAttributeValue("", 3803, Model.Id, 3803, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppFirstSem.Web.Areas.Manage.ViewModels.Employees.EditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
