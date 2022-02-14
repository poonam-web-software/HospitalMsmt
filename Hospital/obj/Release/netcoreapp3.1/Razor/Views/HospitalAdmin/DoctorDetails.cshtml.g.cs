#pragma checksum "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68f078523becfadafa754aa558c7285642b9662d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HospitalAdmin_DoctorDetails), @"mvc.1.0.view", @"/Views/HospitalAdmin/DoctorDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f078523becfadafa754aa558c7285642b9662d", @"/Views/HospitalAdmin/DoctorDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88caee22214edcd79e48d3dce45ad60c3b27aa44", @"/Views/_ViewImports.cshtml")]
    public class Views_HospitalAdmin_DoctorDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hospital.Models.ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditDoctor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HospitalAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DoctorDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure want to delete this appointment ?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
  
    ViewData["Title"] = "DoctorDetails";
    Layout = "~/Views/Shared/_HospitalAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">

    <div class=""row"">
        <!-- Widget Item -->
        <div class=""col-md-12"">
            <div class=""widget-area-2 proclinic-box-shadow"">
                <h2 class=""widget-title"">Doctor Details</h2>
                <hr />
                <div class=""table-responsive"">
                    <table class=""table table-bordered table-striped"">
                        <tbody>
                            <tr>
                                <td>
                                    <h4> ");
#nullable restore
#line 23 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                    Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 26 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>  ");
#nullable restore
#line 31 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 34 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>    ");
#nullable restore
#line 39 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 42 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>  ");
#nullable restore
#line 47 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Specialization));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 50 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.Specialization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>   ");
#nullable restore
#line 55 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 58 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>   ");
#nullable restore
#line 64 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 67 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>     ");
#nullable restore
#line 72 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                        Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 75 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>");
#nullable restore
#line 80 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FaxNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 83 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.FaxNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>");
#nullable restore
#line 88 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 91 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4> ");
#nullable restore
#line 96 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                    Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 99 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>");
#nullable restore
#line 104 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                   Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 107 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>");
#nullable restore
#line 112 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                   Write(Html.DisplayNameFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 115 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>");
#nullable restore
#line 120 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 123 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>   ");
#nullable restore
#line 128 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.DoctorDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 131 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
                               Write(Html.DisplayFor(model => model.DoctorDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>
                            </tr>

                        </tbody>
                    </table>
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination export-pagination"">
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#""><span class=""fa fa-download ""></span> csv</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#""><span class=""fa fa-printer""></span> print</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#""><span class=""fa fa-file ""></span> PDF</a>
                            </li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#""><span class=""fa fa-align-justify""></span> Excel</a>
");
            WriteLiteral("                            </li>\r\n                        </ul>\r\n                    </nav>\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f078523becfadafa754aa558c7285642b9662d19433", async() => {
                WriteLiteral("<i class=\"fa fa-pencil m-r-5\"></i> Edit Doctor");
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
#line 154 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
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
            WriteLiteral("\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f078523becfadafa754aa558c7285642b9662d21753", async() => {
                WriteLiteral("<i class=\"fa fa-trash-o m-r-5\"></i> Delete Doctor");
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
#line 156 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\DoctorDetails.cshtml"
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hospital.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
