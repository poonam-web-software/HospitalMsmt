#pragma checksum "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fa019a28f3ea5c0c260cd1343e797b5ce48cb33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_PatientCaseStudyListDetails), @"mvc.1.0.view", @"/Views/Doctor/PatientCaseStudyListDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fa019a28f3ea5c0c260cd1343e797b5ce48cb33", @"/Views/Doctor/PatientCaseStudyListDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88caee22214edcd79e48d3dce45ad60c3b27aa44", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_PatientCaseStudyListDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hospital.Models.PatientCaseStudy>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
  
    ViewData["Title"] = "PatientCaseStudyListDetails";
    Layout = "~/Views/Shared/_DoctorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">
            <h4 class=""page-title page-title_main"">View  Patient Case Study Details</h4>
        </div>
    </div>
    <div class=""row"">
        <!-- Widget Item -->
        <div class=""col-md-12"">
            <div class=""widget-area-2 proclinic-box-shadow"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered table-striped"">
                        <tbody>

");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 38 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.patientId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  </td>\r\n                                <td> ");
#nullable restore
#line 39 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.patientId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 42 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Hospital_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  </td>\r\n                                <td> ");
#nullable restore
#line 43 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Hospital_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>

                            <tr>
                                <td>
                                        <h4>
                                             Nurse Name
                                        </h4>
                                                                                    
                                    </td>
                                <td> ");
#nullable restore
#line 53 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Doctor_Nurse_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 57 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.FoodAllergies));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  </td>\r\n                                <td> ");
#nullable restore
#line 58 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.FoodAllergies));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 61 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.TendencyBleed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  </td>\r\n                                <td> ");
#nullable restore
#line 62 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.TendencyBleed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 65 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.HeartDisease));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  </td>\r\n                                <td> ");
#nullable restore
#line 66 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.HeartDisease));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 69 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.HighBloodPressure));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  </td>\r\n                                <td> ");
#nullable restore
#line 70 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.HighBloodPressure));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 73 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Diabetic));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  </td>\r\n                                <td> ");
#nullable restore
#line 74 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Diabetic));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 77 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Surgery));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  </td>\r\n                                <td> ");
#nullable restore
#line 78 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Surgery));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 81 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Accident));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  </td>\r\n                                <td> ");
#nullable restore
#line 82 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Accident));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 85 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Others));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  </td>\r\n                                <td> ");
#nullable restore
#line 86 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Others));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 89 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.FamilyMedicalHistory));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  </td>\r\n                                <td> ");
#nullable restore
#line 90 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.FamilyMedicalHistory));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td> <h4> ");
#nullable restore
#line 94 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.CurrentMedication));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>  </td>\r\n                                <td> ");
#nullable restore
#line 95 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.CurrentMedication));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td><h4>   ");
#nullable restore
#line 99 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.FemalePregnancy));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> </td>\r\n                                <td> ");
#nullable restore
#line 100 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.FemalePregnancy));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n\r\n\r\n                            <tr>\r\n                                <td><h4>   ");
#nullable restore
#line 105 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.BreastFeeding));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> </td>\r\n                                <td> ");
#nullable restore
#line 106 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.BreastFeeding));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td><h4>   ");
#nullable restore
#line 110 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.HealthInsurance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> </td>\r\n                                <td> ");
#nullable restore
#line 111 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.HealthInsurance));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td><h4>   ");
#nullable restore
#line 115 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.LowIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> </td>\r\n                                <td> ");
#nullable restore
#line 116 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.LowIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td><h4>   ");
#nullable restore
#line 120 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Reference));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> </td>\r\n                                <td> ");
#nullable restore
#line 121 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Reference));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><h4>   ");
#nullable restore
#line 124 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> </td>\r\n                                <td> ");
#nullable restore
#line 125 "D:\Bitbu\hospitalmanagement\Hospital\Views\Doctor\PatientCaseStudyListDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                            </tr>
                        </tbody>
                    </table>
                    <div class=""m-t-20 text-center"">
                        <button type=""submit"" class=""btn btn-success submit-btn""> <a href=""/Doctor/PatientCaseStudyList"">Go Back</a></button>
                    </div>
                    <br />
");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hospital.Models.PatientCaseStudy> Html { get; private set; }
    }
}
#pragma warning restore 1591
