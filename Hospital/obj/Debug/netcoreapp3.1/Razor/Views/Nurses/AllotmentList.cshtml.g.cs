#pragma checksum "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04964b47ae2b36c43e1db93cf5b978502902afdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nurses_AllotmentList), @"mvc.1.0.view", @"/Views/Nurses/AllotmentList.cshtml")]
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
#line 1 "D:\Bitbu\hospitalmanagement\Hospital\Views\_ViewImports.cshtml"
using Hospital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bitbu\hospitalmanagement\Hospital\Views\_ViewImports.cshtml"
using Hospital.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04964b47ae2b36c43e1db93cf5b978502902afdf", @"/Views/Nurses/AllotmentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88caee22214edcd79e48d3dce45ad60c3b27aa44", @"/Views/_ViewImports.cshtml")]
    public class Views_Nurses_AllotmentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hospital.Models.SubAdmin.Allotment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddAllotment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-rounded float-right room_allot_btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAllotment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllotmentDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Nurses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllotmentDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure want to delete this Room Allotment?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
  
    ViewData["Title"] = "AllotmentList";
    Layout = "~/Views/Shared/_NursesLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
    <div class=""row"">
        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">
            <h2 class=""page-title page-title_main"">Allotments Lists</h2>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04964b47ae2b36c43e1db93cf5b978502902afdf6068", async() => {
                WriteLiteral("<i class=\"fa fa-plus\"></i> Room Allotments  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""table-responsive"">
                <table class=""table table-border table-striped custom-table datatable mb-0"">
                    <thead>
                        <tr>
                            <th>
                                <i class=""fa fa-bed"" aria-hidden=""true""></i>     ");
#nullable restore
#line 23 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                                                            Write(Html.DisplayNameFor(model => model.Room));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                <i class=\"fa fa-medium\" aria-hidden=\"true\"></i>     ");
#nullable restore
#line 26 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                                                               Write(Html.DisplayNameFor(model => model.RoomType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                <i class=\"fa fa-wheelchair\" aria-hidden=\"true\"></i>    ");
#nullable restore
#line 29 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                                                                  Write(Html.DisplayNameFor(model => model.PatientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                <i class=\"fa fa-calendar\" aria-hidden=\"true\"></i>   ");
#nullable restore
#line 32 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                                                               Write(Html.DisplayNameFor(model => model.AllotmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                <i class=\"fa fa-calendar\" aria-hidden=\"true\"></i>  ");
#nullable restore
#line 35 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                                                              Write(Html.DisplayNameFor(model => model.DischargeDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                <i class=\"fa fa-user-md\"></i>  ");
#nullable restore
#line 38 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                                          Write(Html.DisplayNameFor(model => model.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                <i class=\"fa fa-toggle-on\" aria-hidden=\"true\"></i>   ");
#nullable restore
#line 41 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                                                                Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </th>
                            <th class=""text-center"">
                                <i class=""fa fa-gavel""></i>  Actions
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 49 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 53 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Room));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 56 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                               Write(Html.DisplayFor(modelItem => item.RoomType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 59 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                               Write(Html.DisplayFor(modelItem => item.PatientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 62 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                               Write(Html.DisplayFor(modelItem => item.AllotmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 65 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DischargeDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 68 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 71 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                     if (item.Status == "Available")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"custom-badge status-green\">\r\n                                            ");
#nullable restore
#line 74 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </span>\r\n");
#nullable restore
#line 76 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                    }
                                    else if (item.Status == "Not Discharge")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"custom-badge status-red\">\r\n                                            ");
#nullable restore
#line 80 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </span>\r\n");
#nullable restore
#line 82 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                    }
                                    else if (item.Status == "Not Alloted")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"custom-badge status-blue\">\r\n                                            ");
#nullable restore
#line 86 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </span>\r\n");
#nullable restore
#line 88 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td class=\"text-center\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04964b47ae2b36c43e1db93cf5b978502902afdf16513", async() => {
                WriteLiteral("<i class=\"fa fa-pencil-square-o\" style=\"font-size: 19px\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                                                    WriteLiteral(item.AllotmentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04964b47ae2b36c43e1db93cf5b978502902afdf18789", async() => {
                WriteLiteral("<i class=\"fa fa-info-circle m-r-5\" style=\"font-size: 19px; color: lightblue\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                                                       WriteLiteral(item.AllotmentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04964b47ae2b36c43e1db93cf5b978502902afdf21088", async() => {
                WriteLiteral("<i class=\"fa fa-trash-o m-r-5\" style=\"font-size: 19px; color: red\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                                                                                              WriteLiteral(item.AllotmentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 98 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\AllotmentList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hospital.Models.SubAdmin.Allotment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
