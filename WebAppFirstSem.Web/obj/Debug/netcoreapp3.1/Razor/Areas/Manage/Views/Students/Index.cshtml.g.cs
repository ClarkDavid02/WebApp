#pragma checksum "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78765df27fe3389875d4017040467f0c7bc219cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Students_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Students/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
using WebAppFirstSem.Web.Infrastructures.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78765df27fe3389875d4017040467f0c7bc219cf", @"/Areas/Manage/Views/Students/Index.cshtml")]
    public class Areas_Manage_Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppFirstSem.Web.Areas.Manage.ViewModels.Students.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/students/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg-3 btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Student Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Student Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
  
    Layout = "~/areas/manage/views/shared/_managelayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h1>Index</h1>


<div class=""row"">
    <div class=""col-lg-5"">
        <div class=""input-group mt-5"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Students</span>
            </div>
            <select class=""form-control"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"" id=""searchStatus"" onchange=""searchTrigger()"" placeholder=""Student Status"">
");
#nullable restore
#line 19 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                  
                    foreach (StudentStatus studentStatus in Model.StudentStatuses)
                    {
                        if (Model.StudentStatus == studentStatus)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 961, "\"", 983, 1);
#nullable restore
#line 24 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
WriteAttributeValue("", 969, studentStatus, 969, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 24 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                                                               Write(studentStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 25 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1149, "\"", 1171, 1);
#nullable restore
#line 28 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
WriteAttributeValue("", 1157, studentStatus, 1157, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                                                      Write(studentStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 29 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
    </div>

    <div class=""col-lg-3 "">
        <div class=""input-group mt-5"">
            <input type=""text"" id=""searchKeyword"" placeholder=""search student"" class=""form-control"" aria-label=""search student"" aria-describedby=""basic-addon2""");
            BeginWriteAttribute("value", " value=\"", 1559, "\"", 1590, 1);
#nullable restore
#line 38 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
WriteAttributeValue("", 1567, Model.Students.Keyword, 1567, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""input-group-append"">
                <span class=""input-group-text"" id=""basic-addon2""><a href=""#"" onclick=""searchTrigger()""><i class=""fa fa-search"" aria-hidden=""true""></i></a></span>
            </div>
        </div>
    </div>

    <div class=""col-lg-3"">
        <div class=""table-responsive table--no-card m-b-30 mt-md-5"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78765df27fe3389875d4017040467f0c7bc219cf9366", async() => {
                WriteLiteral("\r\n                <i class=\"fa fa-plus\"></i>&nbsp;\r\n                <span>Create Student</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<hr />\r\n\r\n\r\n");
#nullable restore
#line 57 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
 if (Model.Students.Items.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-borderless table-striped table-hover"">
        <thead>
            <tr class=""table-info"">
                <th>FullName</th>
                <th>PhoneNumber</th>
                <th>Address</th>
                <th>Status</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 70 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
              
                foreach (Student student in Model.Students.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 74 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                       Write(student.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 75 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                       Write(student.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 76 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                       Write(student.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 77 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                       Write(student.StudentStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78765df27fe3389875d4017040467f0c7bc219cf12947", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-info\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3000, "~/manage/students/details/", 3000, 26, true);
#nullable restore
#line 79 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
AddHtmlAttributeValue("", 3026, student.Id, 3026, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78765df27fe3389875d4017040467f0c7bc219cf14700", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-upload\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3176, "~/manage/students/edit/", 3176, 23, true);
#nullable restore
#line 80 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
AddHtmlAttributeValue("", 3199, student.Id, 3199, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3352, "\"", 3418, 6);
            WriteAttributeValue("", 3362, "confirmDeleteStudent(\'", 3362, 22, true);
#nullable restore
#line 81 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
WriteAttributeValue("", 3384, student.Id, 3384, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3395, "\',", 3395, 2, true);
            WriteAttributeValue(" ", 3397, "\'", 3398, 2, true);
#nullable restore
#line 81 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
WriteAttributeValue("", 3399, student.FullName, 3399, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3416, "\')", 3416, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Student Delete\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n");
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 96 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <td colspan=""4"">
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"">
                            <li class=""page-item""><span class=""form-control-plaintext"">Page&nbsp;&nbsp;&nbsp;</span></li>
                            <li class=""page-item""><input type=""number""");
            BeginWriteAttribute("value", " value=\"", 4819, "\"", 4852, 1);
#nullable restore
#line 105 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
WriteAttributeValue("", 4827, Model.Students.PageIndex, 4827, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 4894, "\"", 5167, 18);
            WriteAttributeValue("", 4906, "javascript:", 4906, 11, true);
            WriteAttributeValue(" ", 4917, "if(event.keyCode", 4918, 17, true);
            WriteAttributeValue(" ", 4934, "==", 4935, 3, true);
            WriteAttributeValue(" ", 4937, "13", 4938, 3, true);
            WriteAttributeValue(" ", 4940, "&&", 4941, 3, true);
            WriteAttributeValue(" ", 4943, "isNaN(parseInt($(this).val()))==false)", 4944, 39, true);
            WriteAttributeValue(" ", 4982, "window.location=\'/manage/students/index?pageIndex=\'", 4983, 52, true);
            WriteAttributeValue(" ", 5034, "+", 5035, 2, true);
            WriteAttributeValue(" ", 5036, "(isNaN(parseInt($(this).val()))", 5037, 32, true);
            WriteAttributeValue(" ", 5068, "?", 5069, 2, true);
            WriteAttributeValue(" ", 5070, "1", 5071, 2, true);
            WriteAttributeValue(" ", 5072, ":", 5073, 2, true);
            WriteAttributeValue(" ", 5074, "parseInt($(this).val()))", 5075, 25, true);
            WriteAttributeValue(" ", 5099, "+", 5100, 2, true);
            WriteAttributeValue(" ", 5101, "\'&keyword=", 5102, 11, true);
#nullable restore
#line 105 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
WriteAttributeValue("", 5112, Model.Students.Keyword, 5112, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5137, "&status=", 5137, 8, true);
#nullable restore
#line 105 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
WriteAttributeValue("", 5145, Model.StudentStatus, 5145, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></li>\r\n                            <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
#nullable restore
#line 106 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                                                                                                       Write(Model.Students.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
#nullable restore
#line 107 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                              
                                var prev = Model.Students.PageIndex - 1;
                                if (prev > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78765df27fe3389875d4017040467f0c7bc219cf21618", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5616, "~/manage/students/index?keyword=", 5616, 32, true);
#nullable restore
#line 111 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
AddHtmlAttributeValue("", 5648, Model.Students.Keyword, 5648, 23, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5671, "&status=", 5671, 8, true);
#nullable restore
#line 111 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
AddHtmlAttributeValue("", 5679, Model.StudentStatus, 5679, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5699, "&pageSize=", 5699, 10, true);
#nullable restore
#line 111 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
AddHtmlAttributeValue("", 5709, Model.Students.PageSize, 5709, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5733, "&pageIndex=", 5733, 11, true);
#nullable restore
#line 111 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
AddHtmlAttributeValue("", 5744, prev, 5744, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 112 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
#nullable restore
#line 114 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                                                                            Write(Model.Students.PageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 115 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                              
                                var next = Model.Students.PageIndex + 1;
                                if (next <= Model.Students.PageCount)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78765df27fe3389875d4017040467f0c7bc219cf25541", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6282, "~/manage/students/index?keyword=", 6282, 32, true);
#nullable restore
#line 119 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
AddHtmlAttributeValue("", 6314, Model.Students.Keyword, 6314, 23, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6337, "&status=", 6337, 8, true);
#nullable restore
#line 119 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
AddHtmlAttributeValue("", 6345, Model.StudentStatus, 6345, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6365, "&pageSize=", 6365, 10, true);
#nullable restore
#line 119 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
AddHtmlAttributeValue("", 6375, Model.Students.PageSize, 6375, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6399, "&pageIndex=", 6399, 11, true);
#nullable restore
#line 119 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
AddHtmlAttributeValue("", 6410, next, 6410, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 120 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 128 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>0 search results.</p>\r\n");
#nullable restore
#line 132 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Students\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Model Delete-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-delete-student"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete Student</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete <span id=""modal-delete-student-fullname""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-delete-student-confirm""><button type=""button"" class=""btn btn-primary"">Delete Student</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>




<!--MODAL Unpublish-->
<div cla");
            WriteLiteral(@"ss=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-unpublish"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Unpublish Post</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to unpublish <span id=""modal-unpublish-name""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-unpublish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>

<!--MODAL Publish-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-publish"">
    <div class=""modal-dialo");
            WriteLiteral(@"g"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Publish Post</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to publish <span id=""modal-publish-name""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-publish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>



<script type=""text/javascript"">

    ////////////////////UNPUBLISH/////////////////////////////////////////////////////////////////
    function confirmUnpublish(id, name) {
        $(""#modal-unpublish-name");
            WriteLiteral(@""").html(name);
        $(""#modal-unpublish-button"").attr(""onclick"", ""UnpublishStudent('"" + id + ""')"");
        $(""#modal-unpublish"").modal(""show"");
    }
    function UnpublishStudent(id) {
        $.ajax({
            type: ""POST"",
            url: ""/manage/students/unpublish"",
            data: { id: id },
            success: function (data) {
                location.reload();
            },
            error: function (xhr) {
                var response = JSON.parse(xhr.responseText);
                alert(""Error Occured : "" + response.errors[0]);
                location.reload();
            }
        });
    }


    //////////////////PUBLISH///////////////////////////////////////////////////////////////////////
    function confirmPublish(id, name) {
        $(""#modal-publish-name"").html(name);
        $(""#modal-publish-button"").attr(""onclick"", ""PublishStudent('"" + id + ""')"");
        $(""#modal-publish"").modal(""show"");
    }
    function PublishStudent(id) {
        $.ajax");
            WriteLiteral(@"({
            type: ""POST"",
            url: ""/manage/students/publish"",
            data: { id: id },
            success: function (data) {
                location.reload();
            },
            error: function (xhr) {
                var response = JSON.parse(xhr.responseText);
                alert(""Error Occured : "" + response.errors[0]);
                location.reload();
            }
        });
    }

    function confirmDeleteStudent(studentId, Name) {
        $(""#modal-delete-student-fullname"").html(Name);
        $(""#modal-delete-student-confirm"").attr(""href"", ""/manage/students/delete/"" + studentId);
        $(""#modal-delete-student"").modal(""show"");
    }

    $(""#searchKeyword"").keyup(function (event) {
        if (event.keyCode === 13) {
            searchTrigger();
        }
    });

    function searchTrigger() {
        window.location = ""/manage/students/index?pageIndex=1&keyword="" + $(""#searchKeyword"").val() + ""&status="" + $(""#searchStatus"").val();
    }");
            WriteLiteral("\r\n\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppFirstSem.Web.Areas.Manage.ViewModels.Students.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
