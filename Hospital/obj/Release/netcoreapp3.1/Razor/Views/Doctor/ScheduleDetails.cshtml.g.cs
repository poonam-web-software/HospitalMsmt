#pragma checksum "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fd19bdca14860d854129d5471eef6bc7fad7d69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_ScheduleDetails), @"mvc.1.0.view", @"/Views/Doctor/ScheduleDetails.cshtml")]
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
#line 1 "E:\Bitbuket\hospitalmanagement\Hospital\Views\_ViewImports.cshtml"
using Hospital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Bitbuket\hospitalmanagement\Hospital\Views\_ViewImports.cshtml"
using Hospital.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fd19bdca14860d854129d5471eef6bc7fad7d69", @"/Views/Doctor/ScheduleDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88caee22214edcd79e48d3dce45ad60c3b27aa44", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_ScheduleDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hospital.Models.SubAdmin.Schedule>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditSchedule", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Doctor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OnPostDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure want to delete this Schedule ?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
  
    ViewData["Title"] = "ScheduleDetails";
    Layout = "~/Views/Shared/_DoctorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">

    <div class=""row"">
        <!-- Widget Item -->
        <div class=""col-md-12"">
            <div class=""widget-area-2 proclinic-box-shadow"">
                <h2 class=""widget-title"">Schedules Details</h2>
                <hr />
                <div class=""table-responsive"">
                    <table class=""table table-bordered table-striped"">
                        <tbody>
                            <tr>
                                <td><h4> ");
#nullable restore
#line 20 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                    Write(Html.DisplayNameFor(model => model.Doctor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td>  ");
#nullable restore
#line 21 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                 Write(Html.DisplayFor(model => model.Doctor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><h4> ");
#nullable restore
#line 24 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                    Write(Html.DisplayNameFor(model => model.AvailableStartDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td>  ");
#nullable restore
#line 25 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                 Write(Html.DisplayFor(model => model.AvailableStartDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><h4>  ");
#nullable restore
#line 28 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.AvailableEndDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> </td>\r\n                                <td>   ");
#nullable restore
#line 29 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                  Write(Html.DisplayFor(model => model.AvailableEndDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><h4> ");
#nullable restore
#line 32 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                    Write(Html.DisplayNameFor(model => model.AvailableStartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td>  ");
#nullable restore
#line 33 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                 Write(Html.DisplayFor(model => model.AvailableStartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><h4>  ");
#nullable restore
#line 36 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.AvailableEndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td>");
#nullable restore
#line 37 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                               Write(Html.DisplayFor(model => model.AvailableEndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><h4> ");
#nullable restore
#line 40 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                    Write(Html.DisplayNameFor(model => model.TimePerPatient));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td>  ");
#nullable restore
#line 41 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                 Write(Html.DisplayFor(model => model.TimePerPatient));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><h4>  ");
#nullable restore
#line 44 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td>  ");
#nullable restore
#line 45 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                 Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination export-pagination"">
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#""><i class=""fa fa-download ""></i> csv</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#""><i class=""fa fa-printer""></i> print</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#""><i class=""fa fa-file""></i> PDF</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#""><i class=""fa fa-align-justify ""></i> Excel</a>
                            </li>
                        <");
            WriteLiteral("/ul>\r\n                    </nav>\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fd19bdca14860d854129d5471eef6bc7fad7d6912152", async() => {
                WriteLiteral("<i class=\"fa fa-pencil m-r-5\"></i>Edit Schedule");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fd19bdca14860d854129d5471eef6bc7fad7d6914465", async() => {
                WriteLiteral("<i class=\"fa fa-trash-o m-r-5\"></i> Delete Schedule");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "E:\Bitbuket\hospitalmanagement\Hospital\Views\Doctor\ScheduleDetails.cshtml"
                                                                                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hospital.Models.SubAdmin.Schedule> Html { get; private set; }
    }
}
#pragma warning restore 1591
