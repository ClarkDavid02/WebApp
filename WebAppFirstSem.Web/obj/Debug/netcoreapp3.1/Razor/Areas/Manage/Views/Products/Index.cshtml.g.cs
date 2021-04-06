#pragma checksum "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b917457336e167ee56be027925f1dd9f3cbcb34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Products/Index.cshtml")]
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
#line 2 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
using WebAppFirstSem.Web.Infrastructures.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b917457336e167ee56be027925f1dd9f3cbcb34", @"/Areas/Manage/Views/Products/Index.cshtml")]
    public class Areas_Manage_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppFirstSem.Web.Areas.Manage.ViewModels.Products.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/products/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg-3 btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Product Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
  
    Layout = "~/areas/manage/views/shared/_managelayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-5"">
        <div class=""input-group mt-5"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Products</span>
            </div>
            <select class=""form-control"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"" id=""searchStatus"" onchange=""searchTrigger()"" placeholder=""Product Status"">
");
#nullable restore
#line 15 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                  
                    foreach (ProductStatus productStatus in Model.productStatuses)
                    {
                        if (Model.productStatus == productStatus)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 939, "\"", 961, 1);
#nullable restore
#line 20 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
WriteAttributeValue("", 947, productStatus, 947, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 20 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                                                               Write(productStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 21 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1127, "\"", 1149, 1);
#nullable restore
#line 24 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
WriteAttributeValue("", 1135, productStatus, 1135, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                                                      Write(productStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 25 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
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
            BeginWriteAttribute("value", " value=\"", 1539, "\"", 1570, 1);
#nullable restore
#line 34 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
WriteAttributeValue("", 1547, Model.Products.Keyword, 1547, 23, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b917457336e167ee56be027925f1dd9f3cbcb348992", async() => {
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
#line 53 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
 if (Model.Products.Items.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-borderless table-striped table-hover"">
        <thead>
            <tr class=""table-info"">
                <th>Name</th>
                <th>Quantity</th>
                <th>Price</th>
                <th>Status</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 66 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
              
                foreach (Product product in Model.Products.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 70 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 71 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                       Write(product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 72 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                       Write(product.Price.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 73 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                       Write(product.ProductStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b917457336e167ee56be027925f1dd9f3cbcb3412569", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-info\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2976, "~/manage/products/details/", 2976, 26, true);
#nullable restore
#line 75 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 3002, product.Id, 3002, 11, false);

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
            BeginWriteAttribute("onclick", " onclick=\"", 3154, "\"", 3216, 6);
            WriteAttributeValue("", 3164, "confirmDeleteProduct(\'", 3164, 22, true);
#nullable restore
#line 76 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
WriteAttributeValue("", 3186, product.Id, 3186, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3197, "\',", 3197, 2, true);
            WriteAttributeValue(" ", 3199, "\'", 3200, 2, true);
#nullable restore
#line 76 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
WriteAttributeValue("", 3201, product.Name, 3201, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3214, "\')", 3214, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Delete Service\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n");
#nullable restore
#line 77 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                              
                                if (product.IsPublished)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-inline-item\"><a href=\"#\" title=\"Unpublish\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3537, "\"", 3594, 5);
            WriteAttributeValue("", 3547, "confirmUnpublish(\'", 3547, 18, true);
#nullable restore
#line 80 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
WriteAttributeValue("", 3565, product.Id, 3565, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3576, "\',\'", 3576, 3, true);
#nullable restore
#line 80 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
WriteAttributeValue("", 3579, product.Name, 3579, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3592, "\')", 3592, 2, true);
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn-danger form-control-sm\"><i class=\"fas fa-window-close\"></i></button></a></li>\r\n");
#nullable restore
#line 81 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-inline-item\"><a href=\"#\" title=\"Publish\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3894, "\"", 3949, 5);
            WriteAttributeValue("", 3904, "confirmPublish(\'", 3904, 16, true);
#nullable restore
#line 84 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
WriteAttributeValue("", 3920, product.Id, 3920, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3931, "\',\'", 3931, 3, true);
#nullable restore
#line 84 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
WriteAttributeValue("", 3934, product.Name, 3934, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3947, "\')", 3947, 2, true);
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn-success form-control-sm\"><i class=\"fas fa-check-square\"></i></button></a></li>\r\n");
#nullable restore
#line 85 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 91 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
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
            BeginWriteAttribute("value", " value=\"", 4605, "\"", 4638, 1);
#nullable restore
#line 100 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
WriteAttributeValue("", 4613, Model.Products.PageIndex, 4613, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 4680, "\"", 4953, 18);
            WriteAttributeValue("", 4692, "javascript:", 4692, 11, true);
            WriteAttributeValue(" ", 4703, "if(event.keyCode", 4704, 17, true);
            WriteAttributeValue(" ", 4720, "==", 4721, 3, true);
            WriteAttributeValue(" ", 4723, "13", 4724, 3, true);
            WriteAttributeValue(" ", 4726, "&&", 4727, 3, true);
            WriteAttributeValue(" ", 4729, "isNaN(parseInt($(this).val()))==false)", 4730, 39, true);
            WriteAttributeValue(" ", 4768, "window.location=\'/manage/products/index?pageIndex=\'", 4769, 52, true);
            WriteAttributeValue(" ", 4820, "+", 4821, 2, true);
            WriteAttributeValue(" ", 4822, "(isNaN(parseInt($(this).val()))", 4823, 32, true);
            WriteAttributeValue(" ", 4854, "?", 4855, 2, true);
            WriteAttributeValue(" ", 4856, "1", 4857, 2, true);
            WriteAttributeValue(" ", 4858, ":", 4859, 2, true);
            WriteAttributeValue(" ", 4860, "parseInt($(this).val()))", 4861, 25, true);
            WriteAttributeValue(" ", 4885, "+", 4886, 2, true);
            WriteAttributeValue(" ", 4887, "\'&keyword=", 4888, 11, true);
#nullable restore
#line 100 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
WriteAttributeValue("", 4898, Model.Products.Keyword, 4898, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4923, "&status=", 4923, 8, true);
#nullable restore
#line 100 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
WriteAttributeValue("", 4931, Model.productStatus, 4931, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></li>\r\n                            <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
#nullable restore
#line 101 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                                                                                                       Write(Model.Products.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
#nullable restore
#line 102 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                              
                                var prev = Model.Products.PageIndex - 1;
                                if (prev > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b917457336e167ee56be027925f1dd9f3cbcb3422548", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5402, "~/manage/products?keyword=", 5402, 26, true);
#nullable restore
#line 106 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 5428, Model.Products.Keyword, 5428, 23, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5451, "&status=", 5451, 8, true);
#nullable restore
#line 106 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 5459, Model.productStatus, 5459, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5479, "&pageSize=", 5479, 10, true);
#nullable restore
#line 106 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 5489, Model.Products.PageSize, 5489, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5513, "&pageIndex=", 5513, 11, true);
#nullable restore
#line 106 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 5524, prev, 5524, 5, false);

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
#line 107 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
#nullable restore
#line 109 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                                                                            Write(Model.Products.PageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 110 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                              
                                var next = Model.Products.PageIndex + 1;
                                if (next <= Model.Products.PageCount)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b917457336e167ee56be027925f1dd9f3cbcb3426465", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6062, "~/manage/products/index?keyword=", 6062, 32, true);
#nullable restore
#line 114 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 6094, Model.Products.Keyword, 6094, 23, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6117, "&status=", 6117, 8, true);
#nullable restore
#line 114 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 6125, Model.productStatus, 6125, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6145, "&pageSize=", 6145, 10, true);
#nullable restore
#line 114 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 6155, Model.Products.PageSize, 6155, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6179, "&pageIndex=", 6179, 11, true);
#nullable restore
#line 114 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 6190, next, 6190, 5, false);

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
#line 115 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 123 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>0 search results.</p>\r\n");
#nullable restore
#line 127 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRooCdWebApp\WebAppFirstSem.Web\Areas\Manage\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Model Delete-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-delete-product"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete Product</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete <span id=""modal-delete-product-name""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-delete-product-confirm""><button type=""button"" class=""btn btn-primary"">Delete Product</button></a>
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
        $(""#modal-unpublish-button"").attr(""onclick"", ""UnpublishProduct('"" + id + ""')"");
        $(""#modal-unpublish"").modal(""show"");
    }
    function UnpublishProduct(id) {
        $.ajax({
            type: ""POST"",
            url: ""/manage/products/unpublish"",
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
        $(""#modal-publish-button"").attr(""onclick"", ""PublishProduct('"" + id + ""')"");
        $(""#modal-publish"").modal(""show"");
    }
    function PublishProduct(id) {
        $.ajax({
");
            WriteLiteral(@"            type: ""POST"",
            url: ""/manage/products/publish"",
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

    function confirmDeleteProduct(productId, Name) {
        $(""#modal-delete-service-vehicle"").html(Name);
        $(""#modal-delete-service-confirm"").attr(""href"", ""/manage/products/delete/"" + productId);
        $(""#modal-delete-service"").modal(""show"");
    }

    $(""#searchKeyword"").keyup(function (event) {
        if (event.keyCode === 13) {
            searchTrigger();
        }
    });

    function searchTrigger() {
        window.location = ""/manage/products/index?pageIndex=1&keyword="" + $(""#searchKeyword"").val() + ""&status="" + $(""#searchStatus"").val();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppFirstSem.Web.Areas.Manage.ViewModels.Products.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
