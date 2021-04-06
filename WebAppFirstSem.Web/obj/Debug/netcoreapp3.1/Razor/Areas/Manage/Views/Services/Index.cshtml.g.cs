#pragma checksum "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c4c5196e41604edff9a8f1cff223123bd0cd2b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Services_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Services/Index.cshtml")]
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
#line 2 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
using WebAppFirstSem.Web.Infrastructures.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c4c5196e41604edff9a8f1cff223123bd0cd2b4", @"/Areas/Manage/Views/Services/Index.cshtml")]
    public class Areas_Manage_Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppFirstSem.Web.Areas.Manage.ViewModels.Services.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/services/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg-3 btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Service Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
  
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
                <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Services</span>
            </div>
            <select class=""form-control"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"" id=""searchStatus"" onchange=""searchTrigger()"" placeholder=""Service Status"">
");
#nullable restore
#line 18 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                  
                    foreach (ServiceStatus serviceStatus in Model.serviceStatuses)
                    {
                        if (Model.ServiceStatus == serviceStatus)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 959, "\"", 981, 1);
#nullable restore
#line 23 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 967, serviceStatus, 967, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 23 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                                                               Write(serviceStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 24 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1147, "\"", 1169, 1);
#nullable restore
#line 27 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 1155, serviceStatus, 1155, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                                                      Write(serviceStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 28 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
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
            <input type=""text"" id=""searchKeyword"" placeholder=""search services"" class=""form-control"" aria-label=""search services"" aria-describedby=""basic-addon2""");
            BeginWriteAttribute("value", " value=\"", 1559, "\"", 1590, 1);
#nullable restore
#line 37 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 1567, Model.Services.Keyword, 1567, 23, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c4c5196e41604edff9a8f1cff223123bd0cd2b49012", async() => {
                WriteLiteral("\r\n                <i class=\"fa fa-plus\"></i>&nbsp;\r\n                <span>Create Product</span>\r\n            ");
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
#line 56 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
 if (Model.Services.Items.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-borderless table-striped table-hover"">
        <thead>
            <tr class=""table-info"">
                <th>Name</th>
                <th>Description</th>
                <th>Price</th>
                <th>Status</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 69 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
              
                foreach (Service service in Model.Services.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 73 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                       Write(service.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 74 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                       Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 75 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                       Write(service.Price.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 76 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                       Write(service.ServiceStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c4c5196e41604edff9a8f1cff223123bd0cd2b412595", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-info\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3002, "~/manage/services/details/", 3002, 26, true);
#nullable restore
#line 78 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 3028, service.Id, 3028, 11, false);

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
            BeginWriteAttribute("onclick", " onclick=\"", 3180, "\"", 3242, 6);
            WriteAttributeValue("", 3190, "confirmDeleteService(\'", 3190, 22, true);
#nullable restore
#line 79 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 3212, service.Id, 3212, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3223, "\',", 3223, 2, true);
            WriteAttributeValue(" ", 3225, "\'", 3226, 2, true);
#nullable restore
#line 79 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 3227, service.Name, 3227, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3240, "\')", 3240, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Delete Service\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n");
#nullable restore
#line 80 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                              
                                if (service.IsPublished)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-inline-item\"><a href=\"#\" title=\"Unpublish\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3563, "\"", 3620, 5);
            WriteAttributeValue("", 3573, "confirmUnpublish(\'", 3573, 18, true);
#nullable restore
#line 83 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 3591, service.Id, 3591, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3602, "\',\'", 3602, 3, true);
#nullable restore
#line 83 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 3605, service.Name, 3605, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3618, "\')", 3618, 2, true);
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn-danger form-control-sm\"><i class=\"fas fa-window-close\"></i></button></a></li>\r\n");
#nullable restore
#line 84 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-inline-item\"><a href=\"#\" title=\"Publish\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3920, "\"", 3975, 5);
            WriteAttributeValue("", 3930, "confirmPublish(\'", 3930, 16, true);
#nullable restore
#line 87 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 3946, service.Id, 3946, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3957, "\',\'", 3957, 3, true);
#nullable restore
#line 87 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 3960, service.Name, 3960, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3973, "\')", 3973, 2, true);
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn-success form-control-sm\"><i class=\"fas fa-check-square\"></i></button></a></li>\r\n");
#nullable restore
#line 88 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 94 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
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
            BeginWriteAttribute("value", " value=\"", 4631, "\"", 4664, 1);
#nullable restore
#line 103 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 4639, Model.Services.PageIndex, 4639, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 4706, "\"", 4979, 18);
            WriteAttributeValue("", 4718, "javascript:", 4718, 11, true);
            WriteAttributeValue(" ", 4729, "if(event.keyCode", 4730, 17, true);
            WriteAttributeValue(" ", 4746, "==", 4747, 3, true);
            WriteAttributeValue(" ", 4749, "13", 4750, 3, true);
            WriteAttributeValue(" ", 4752, "&&", 4753, 3, true);
            WriteAttributeValue(" ", 4755, "isNaN(parseInt($(this).val()))==false)", 4756, 39, true);
            WriteAttributeValue(" ", 4794, "window.location=\'/manage/services/index?pageIndex=\'", 4795, 52, true);
            WriteAttributeValue(" ", 4846, "+", 4847, 2, true);
            WriteAttributeValue(" ", 4848, "(isNaN(parseInt($(this).val()))", 4849, 32, true);
            WriteAttributeValue(" ", 4880, "?", 4881, 2, true);
            WriteAttributeValue(" ", 4882, "1", 4883, 2, true);
            WriteAttributeValue(" ", 4884, ":", 4885, 2, true);
            WriteAttributeValue(" ", 4886, "parseInt($(this).val()))", 4887, 25, true);
            WriteAttributeValue(" ", 4911, "+", 4912, 2, true);
            WriteAttributeValue(" ", 4913, "\'&keyword=", 4914, 11, true);
#nullable restore
#line 103 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 4924, Model.Services.Keyword, 4924, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4949, "&status=", 4949, 8, true);
#nullable restore
#line 103 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
WriteAttributeValue("", 4957, Model.ServiceStatus, 4957, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></li>\r\n                            <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
#nullable restore
#line 104 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                                                                                                       Write(Model.Services.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
#nullable restore
#line 105 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                              
                                var prev = Model.Services.PageIndex - 1;
                                if (prev > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c4c5196e41604edff9a8f1cff223123bd0cd2b422574", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5428, "~/manage/services?keyword=", 5428, 26, true);
#nullable restore
#line 109 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 5454, Model.Services.Keyword, 5454, 23, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5477, "&status=", 5477, 8, true);
#nullable restore
#line 109 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 5485, Model.ServiceStatus, 5485, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5505, "&pageSize=", 5505, 10, true);
#nullable restore
#line 109 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 5515, Model.Services.PageSize, 5515, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5539, "&pageIndex=", 5539, 11, true);
#nullable restore
#line 109 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 5550, prev, 5550, 5, false);

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
#line 110 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
#nullable restore
#line 112 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                                                                            Write(Model.Services.PageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 113 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                              
                                var next = Model.Services.PageIndex + 1;
                                if (next <= Model.Services.PageCount)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c4c5196e41604edff9a8f1cff223123bd0cd2b426491", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6088, "~/manage/services/index?keyword=", 6088, 32, true);
#nullable restore
#line 117 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 6120, Model.Services.Keyword, 6120, 23, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6143, "&status=", 6143, 8, true);
#nullable restore
#line 117 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 6151, Model.ServiceStatus, 6151, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6171, "&pageSize=", 6171, 10, true);
#nullable restore
#line 117 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 6181, Model.Services.PageSize, 6181, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6205, "&pageIndex=", 6205, 11, true);
#nullable restore
#line 117 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 6216, next, 6216, 5, false);

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
#line 118 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 126 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>0 search results.</p>\r\n");
#nullable restore
#line 130 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Services\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Model Delete-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-delete-service"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete Service</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete <span id=""modal-delete-service-name""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-delete-service-confirm""><button type=""button"" class=""btn btn-primary"">Delete Service</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>




<!--MODAL Unpublish-->
<div class=""");
            WriteLiteral(@"modal"" tabindex=""-1"" role=""dialog"" id=""modal-unpublish"">
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
    <div class=""modal-dialog"" r");
            WriteLiteral(@"ole=""document"">
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
        $(""#modal-unpublish-name"").h");
            WriteLiteral(@"tml(name);
        $(""#modal-unpublish-button"").attr(""onclick"", ""UnpublishService('"" + id + ""')"");
        $(""#modal-unpublish"").modal(""show"");
    }
    function UnpublishService(id) {
        $.ajax({
            type: ""POST"",
            url: ""/manage/services/unpublish"",
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
        $(""#modal-publish-button"").attr(""onclick"", ""PublishService('"" + id + ""')"");
        $(""#modal-publish"").modal(""show"");
    }
    function PublishService(id) {
        $.ajax({
");
            WriteLiteral(@"            type: ""POST"",
            url: ""/manage/services/publish"",
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

    function confirmDeleteService(serviceId, Name) {
        $(""#modal-delete-service-vehicle"").html(Name);
        $(""#modal-delete-service-confirm"").attr(""href"", ""/manage/services/delete/"" + serviceId);
        $(""#modal-delete-service"").modal(""show"");
    }

    $(""#searchKeyword"").keyup(function (event) {
        if (event.keyCode === 13) {
            searchTrigger();
        }
    });

    function searchTrigger() {
        window.location = ""/manage/services/index?pageIndex=1&keyword="" + $(""#searchKeyword"").val() + ""&status="" + $(""#searchStatus"").val();
    }

");
            WriteLiteral("\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppFirstSem.Web.Areas.Manage.ViewModels.Services.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
