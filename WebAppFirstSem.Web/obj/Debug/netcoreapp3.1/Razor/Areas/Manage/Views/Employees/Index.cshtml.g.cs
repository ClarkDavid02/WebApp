#pragma checksum "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bd7023e5db037ce61d1d405a91825d78d9927a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Employees_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Employees/Index.cshtml")]
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
#line 2 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
using WebAppFirstSem.Web.Infrastructures.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd7023e5db037ce61d1d405a91825d78d9927a2", @"/Areas/Manage/Views/Employees/Index.cshtml")]
    public class Areas_Manage_Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppFirstSem.Web.Areas.Manage.ViewModels.Employees.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/employees/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg-3 btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Employee Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
  
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
                <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Employees</span>
            </div>
            <select class=""form-control"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"" id=""searchStatus"" onchange=""searchTrigger()"" placeholder=""Employee Status"">
");
#nullable restore
#line 19 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                  
                    foreach (EmployeeStatus employeeStatus in Model.EmployeeStatuses)
                    {
                        if (Model.EmployeeStatus == employeeStatus)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 969, "\"", 992, 1);
#nullable restore
#line 24 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
WriteAttributeValue("", 977, employeeStatus, 977, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 24 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                                                                Write(employeeStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 25 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1159, "\"", 1182, 1);
#nullable restore
#line 28 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
WriteAttributeValue("", 1167, employeeStatus, 1167, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                                                       Write(employeeStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 29 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
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
            <input type=""text"" id=""searchKeyword"" placeholder=""search student"" class=""form-control"" aria-label=""search employee"" aria-describedby=""basic-addon2""");
            BeginWriteAttribute("value", " value=\"", 1572, "\"", 1603, 1);
#nullable restore
#line 38 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
WriteAttributeValue("", 1580, Model.Employee.Keyword, 1580, 23, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd7023e5db037ce61d1d405a91825d78d9927a29021", async() => {
                WriteLiteral("\r\n                <i class=\"fa fa-plus\"></i>&nbsp;\r\n                <span>Create Employee</span>\r\n            ");
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
#line 57 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
 if (Model.Employee.Items.Count > 0)
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
#line 70 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
              
                foreach (Employee employee in Model.Employee.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 74 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                       Write(employee.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 75 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                       Write(employee.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 76 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                       Write(employee.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 77 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                       Write(employee.EmployeeStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd7023e5db037ce61d1d405a91825d78d9927a212604", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-info\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3022, "~/manage/employees/details/", 3022, 27, true);
#nullable restore
#line 79 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
AddHtmlAttributeValue("", 3049, employee.Id, 3049, 12, false);

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
            WriteLiteral("\r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3203, "\"", 3272, 6);
            WriteAttributeValue("", 3213, "confirmDeleteEmployee(\'", 3213, 23, true);
#nullable restore
#line 80 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
WriteAttributeValue("", 3236, employee.Id, 3236, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3248, "\',", 3248, 2, true);
            WriteAttributeValue(" ", 3250, "\'", 3251, 2, true);
#nullable restore
#line 80 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
WriteAttributeValue("", 3252, employee.FullName, 3252, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3270, "\')", 3270, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Delete Service\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n");
#nullable restore
#line 81 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                              
                                if (employee.IsPublished)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-inline-item\"><a href=\"#\" title=\"Unpublish\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3594, "\"", 3657, 5);
            WriteAttributeValue("", 3604, "confirmUnpublish(\'", 3604, 18, true);
#nullable restore
#line 84 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
WriteAttributeValue("", 3622, employee.Id, 3622, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3634, "\',\'", 3634, 3, true);
#nullable restore
#line 84 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
WriteAttributeValue("", 3637, employee.FullName, 3637, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3655, "\')", 3655, 2, true);
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn-danger form-control-sm\"><i class=\"fas fa-window-close\"></i></button></a></li>\r\n");
#nullable restore
#line 85 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-inline-item\"><a href=\"#\" title=\"Publish\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3957, "\"", 4018, 5);
            WriteAttributeValue("", 3967, "confirmPublish(\'", 3967, 16, true);
#nullable restore
#line 88 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
WriteAttributeValue("", 3983, employee.Id, 3983, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3995, "\',\'", 3995, 3, true);
#nullable restore
#line 88 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
WriteAttributeValue("", 3998, employee.FullName, 3998, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4016, "\')", 4016, 2, true);
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn-success form-control-sm\"><i class=\"fas fa-check-square\"></i></button></a></li>\r\n");
#nullable restore
#line 89 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 95 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
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
            BeginWriteAttribute("value", " value=\"", 4674, "\"", 4707, 1);
#nullable restore
#line 104 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
WriteAttributeValue("", 4682, Model.Employee.PageIndex, 4682, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 4749, "\"", 5024, 18);
            WriteAttributeValue("", 4761, "javascript:", 4761, 11, true);
            WriteAttributeValue(" ", 4772, "if(event.keyCode", 4773, 17, true);
            WriteAttributeValue(" ", 4789, "==", 4790, 3, true);
            WriteAttributeValue(" ", 4792, "13", 4793, 3, true);
            WriteAttributeValue(" ", 4795, "&&", 4796, 3, true);
            WriteAttributeValue(" ", 4798, "isNaN(parseInt($(this).val()))==false)", 4799, 39, true);
            WriteAttributeValue(" ", 4837, "window.location=\'/manage/employees/index?pageIndex=\'", 4838, 53, true);
            WriteAttributeValue(" ", 4890, "+", 4891, 2, true);
            WriteAttributeValue(" ", 4892, "(isNaN(parseInt($(this).val()))", 4893, 32, true);
            WriteAttributeValue(" ", 4924, "?", 4925, 2, true);
            WriteAttributeValue(" ", 4926, "1", 4927, 2, true);
            WriteAttributeValue(" ", 4928, ":", 4929, 2, true);
            WriteAttributeValue(" ", 4930, "parseInt($(this).val()))", 4931, 25, true);
            WriteAttributeValue(" ", 4955, "+", 4956, 2, true);
            WriteAttributeValue(" ", 4957, "\'&keyword=", 4958, 11, true);
#nullable restore
#line 104 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
WriteAttributeValue("", 4968, Model.Employee.Keyword, 4968, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4993, "&status=", 4993, 8, true);
#nullable restore
#line 104 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
WriteAttributeValue("", 5001, Model.EmployeeStatus, 5001, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></li>\r\n                            <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
#nullable restore
#line 105 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                                                                                                       Write(Model.Employee.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
#nullable restore
#line 106 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                              
                                var prev = Model.Employee.PageIndex - 1;
                                if (prev > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd7023e5db037ce61d1d405a91825d78d9927a222591", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5473, "~/manage/employees/index?keyword=", 5473, 33, true);
#nullable restore
#line 110 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
AddHtmlAttributeValue("", 5506, Model.Employee.Keyword, 5506, 23, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5529, "&status=", 5529, 8, true);
#nullable restore
#line 110 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
AddHtmlAttributeValue("", 5537, Model.EmployeeStatus, 5537, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5558, "&pageSize=", 5558, 10, true);
#nullable restore
#line 110 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
AddHtmlAttributeValue("", 5568, Model.Employee.PageSize, 5568, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5592, "&pageIndex=", 5592, 11, true);
#nullable restore
#line 110 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
AddHtmlAttributeValue("", 5603, prev, 5603, 5, false);

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
#line 111 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
#nullable restore
#line 113 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                                                                            Write(Model.Employee.PageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 114 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                              
                                var next = Model.Employee.PageIndex + 1;
                                if (next <= Model.Employee.PageCount)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd7023e5db037ce61d1d405a91825d78d9927a226509", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6141, "~/manage/employees/index?keyword=", 6141, 33, true);
#nullable restore
#line 118 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
AddHtmlAttributeValue("", 6174, Model.Employee.Keyword, 6174, 23, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6197, "&status=", 6197, 8, true);
#nullable restore
#line 118 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
AddHtmlAttributeValue("", 6205, Model.EmployeeStatus, 6205, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6226, "&pageSize=", 6226, 10, true);
#nullable restore
#line 118 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
AddHtmlAttributeValue("", 6236, Model.Employee.PageSize, 6236, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6260, "&pageIndex=", 6260, 11, true);
#nullable restore
#line 118 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
AddHtmlAttributeValue("", 6271, next, 6271, 5, false);

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
#line 119 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 127 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>0 search results.</p>\r\n");
#nullable restore
#line 131 "C:\Users\VGD PC 9\source\repos\WebAppFirstSem\WebAppFirstSem.Web\Areas\Manage\Views\Employees\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Model Delete-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-delete-employee"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete Employee</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete <span id=""modal-delete-employee-fullname""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-delete-employees-confirm""><button type=""button"" class=""btn btn-primary"">Delete Employee</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>




<!--MODAL Unpublish-->
<d");
            WriteLiteral(@"iv class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-unpublish"">
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
    <div class=""modal");
            WriteLiteral(@"-dialog"" role=""document"">
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
        $(""#modal-unpublis");
            WriteLiteral(@"h-name"").html(name);
        $(""#modal-unpublish-button"").attr(""onclick"", ""UnpublishEmployee('"" + id + ""')"");
        $(""#modal-unpublish"").modal(""show"");
    }
    function UnpublishEmployee(id) {
        $.ajax({
            type: ""POST"",
            url: ""/manage/employees/unpublish"",
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
        $(""#modal-publish-button"").attr(""onclick"", ""PublishEmployee('"" + id + ""')"");
        $(""#modal-publish"").modal(""show"");
    }
    function PublishEmployee(id) {
   ");
            WriteLiteral(@"     $.ajax({
            type: ""POST"",
            url: ""/manage/employees/publish"",
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

    function confirmDeleteProduct(studentId, Name) {
        $(""#modal-delete-employee-fullname"").html(Name);
        $(""#modal-delete-employee-confirm"").attr(""href"", ""/manage/employees/delete/"" + studentId);
        $(""#modal-delete-student"").modal(""show"");
    }

    $(""#searchKeyword"").keyup(function (event) {
        if (event.keyCode === 13) {
            searchTrigger();
        }
    });

    function searchTrigger() {
        window.location = ""/manage/employees/index?pageIndex=1&keyword="" + $(""#searchKeyword"").val() + ""&status="" + $(""#searchStatus");
            WriteLiteral("\").val();\r\n    }\r\n\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppFirstSem.Web.Areas.Manage.ViewModels.Employees.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
