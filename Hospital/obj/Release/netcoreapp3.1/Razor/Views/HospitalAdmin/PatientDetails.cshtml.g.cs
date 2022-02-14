#pragma checksum "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60d590887a5b354fba2524290e0908bb76b82a14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HospitalAdmin_PatientDetails), @"mvc.1.0.view", @"/Views/HospitalAdmin/PatientDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60d590887a5b354fba2524290e0908bb76b82a14", @"/Views/HospitalAdmin/PatientDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88caee22214edcd79e48d3dce45ad60c3b27aa44", @"/Views/_ViewImports.cshtml")]
    public class Views_HospitalAdmin_PatientDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hospital.Models.SubAdmin.Patients>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPatient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HospitalAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PatientDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure want to delete this Patient ?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
  
    ViewData["Title"] = "PatientDetails";
    Layout = "~/Views/Shared/_HospitalAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .patient_stuatus {
        border-radius: 4px;
        display: inline-block;
        font-size: 15px;
        min-width: 95px;
        padding: 5px 10px;
        text-align: center;
    }

    .emergency_contact_detail {
        text-align: center;
    font-size: x-large;
    border: 2px solid red;
    border-bottom: none;
    }
</style>

<div class=""container-fluid"">
    <br>
    <div class=""row"">
        <!-- Widget Item -->
        <div class=""col-md-12"">
            <div class=""widget-area-2 proclinic-box-shadow"">
                <h2 class=""widget-title"">Patients Details</h2>

                <h2 class=""pull-right"" style=""        margin-top: revert;
"">Patient ID: <span style=""color: lightskyblue;"">");
#nullable restore
#line 35 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                            Write(Html.DisplayFor(model => model.PatientID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                <hr />\r\n                <h2>\r\n");
#nullable restore
#line 38 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                     if (Model.IsActive == "Active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"patient_stuatus status-green\">\r\n                            ");
#nullable restore
#line 41 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                       Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n");
#nullable restore
#line 43 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                    }
                    else if (Model.IsActive == "Not Active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"custom_badge status-red\">\r\n                            ");
#nullable restore
#line 47 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                       Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n");
#nullable restore
#line 49 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </h2>\r\n                <div class=\"table-responsive\">\r\n                    <table class=\"table table-bordered table-striped\">\r\n                        <tbody>\r\n                            <tr>\r\n                                <td><h4> ");
#nullable restore
#line 55 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                    Write(Html.DisplayNameFor(model => model.PatientName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4></td>\r\n                                <td> ");
#nullable restore
#line 56 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                Write(Html.DisplayFor(model => model.PatientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 59 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td>  ");
#nullable restore
#line 60 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                 Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>  <h4> ");
#nullable restore
#line 63 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td>   ");
#nullable restore
#line 64 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                  Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 67 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td>  ");
#nullable restore
#line 68 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                 Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> <h4>");
#nullable restore
#line 71 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                    Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td>   ");
#nullable restore
#line 72 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                  Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n\r\n\r\n                            <tr>\r\n                                <td> <h4>  ");
#nullable restore
#line 77 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td> ");
#nullable restore
#line 78 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>");
#nullable restore
#line 82 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 85 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                               Write(Html.DisplayFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4> ");
#nullable restore
#line 90 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                    Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 93 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                               Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>");
#nullable restore
#line 98 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                   Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 101 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                               Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>");
#nullable restore
#line 106 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                   Write(Html.DisplayNameFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 109 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                               Write(Html.DisplayFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>");
#nullable restore
#line 114 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 117 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                               Write(Html.DisplayFor(model => model.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>");
#nullable restore
#line 122 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 125 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                               Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <h4>");
#nullable restore
#line 130 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 133 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                               Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                            <tr>\r\n                                <td>  <h4> ");
#nullable restore
#line 138 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td> ");
#nullable restore
#line 139 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>  <h4> ");
#nullable restore
#line 142 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td> ");
#nullable restore
#line 143 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>  <h4> ");
#nullable restore
#line 146 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td> ");
#nullable restore
#line 147 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>  <h4> ");
#nullable restore
#line 150 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Patient_Visit_Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                                <td> ");
#nullable restore
#line 151 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Patient_Visit_Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                            </tr>
                            <tr class=""emergency_contact_detail""><td colspan=""2"">Emergency Contact</td></tr>
                            <tr style=""border-right: 2px solid red;
    border-left: 2px solid red;"">
                                <td>  <h4>Name</h4></td>
                                <td> ");
#nullable restore
#line 157 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Emergency_Contact_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n                            <tr style=\"border: 2px solid red;\r\n    border-top: none;\">\r\n                                <td>  <h4>Contact Number</h4></td>\r\n                                <td> ");
#nullable restore
#line 162 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Emergency_Contact_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
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
                        ");
            WriteLiteral("</ul>\r\n                    </nav>\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60d590887a5b354fba2524290e0908bb76b82a1424332", async() => {
                WriteLiteral("<i class=\"fa fa-pencil m-r-5\"></i>Edit Patients");
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
#line 183 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                                      WriteLiteral(Model.PatientID);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60d590887a5b354fba2524290e0908bb76b82a1426658", async() => {
                WriteLiteral("<i class=\"fa fa-trash-o m-r-5\"></i> Delete Patient");
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
#line 184 "E:\Bitbuket\hospitalmanagement\Hospital\Views\HospitalAdmin\PatientDetails.cshtml"
                                                                                                                   WriteLiteral(Model.PatientID);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hospital.Models.SubAdmin.Patients> Html { get; private set; }
    }
}
#pragma warning restore 1591
