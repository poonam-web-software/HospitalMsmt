#pragma checksum "D:\Bitbu\hospitalmanagement\Hospital\Views\HospitalAdmin\Hostpitalpatients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "992ea89300a8fb20b2482de7883e54e9284393f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HospitalAdmin_Hostpitalpatients), @"mvc.1.0.view", @"/Views/HospitalAdmin/Hostpitalpatients.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"992ea89300a8fb20b2482de7883e54e9284393f8", @"/Views/HospitalAdmin/Hostpitalpatients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88caee22214edcd79e48d3dce45ad60c3b27aa44", @"/Views/_ViewImports.cshtml")]
    public class Views_HospitalAdmin_Hostpitalpatients : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hospital.Models.SubAdmin.Patients>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/pages/HospitalAdmin/HospitalPatients.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Bitbu\hospitalmanagement\Hospital\Views\HospitalAdmin\Hostpitalpatients.cshtml"
  
    ViewData["Title"] = "Hostpital patients";
    Layout = "~/Views/Shared/_HospitalAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    td {
        width: 60px!important;
    }
</style>
<div class=""content"">
    <div class=""row"">
        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">
            <h4 class=""page-title page-title_main"">Patients</h4>
        </div>
    </div>


    <div class=""row"">
        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-12"">
            <div class=""table-responsive"">
                <table class=""display table table-border"" id=""tblPatient"">
                    <thead>
                        <tr>
                            <th><i class=""fa fa-id-card"" aria-hidden=""true""></i> S.No</th>
                            <th>
                                <i class=""fa fa-wheelchair"" aria-hidden=""true""></i> ");
#nullable restore
#line 27 "D:\Bitbu\hospitalmanagement\Hospital\Views\HospitalAdmin\Hostpitalpatients.cshtml"
                                                                               Write(Html.DisplayNameFor(model => model.PatientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                <i class=\"fa fa-line-chart\" aria-hidden=\"true\"></i>  ");
#nullable restore
#line 30 "D:\Bitbu\hospitalmanagement\Hospital\Views\HospitalAdmin\Hostpitalpatients.cshtml"
                                                                                Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                <i class=\"fa fa-envelope-o\" aria-hidden=\"true\"></i>   ");
#nullable restore
#line 33 "D:\Bitbu\hospitalmanagement\Hospital\Views\HospitalAdmin\Hostpitalpatients.cshtml"
                                                                                 Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                <i class=\"fa fa-phone\" aria-hidden=\"true\"></i>  ");
#nullable restore
#line 36 "D:\Bitbu\hospitalmanagement\Hospital\Views\HospitalAdmin\Hostpitalpatients.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                <i class=\"fa fa-toggle-on\" aria-hidden=\"true\"></i>  ");
#nullable restore
#line 39 "D:\Bitbu\hospitalmanagement\Hospital\Views\HospitalAdmin\Hostpitalpatients.cshtml"
                                                                               Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </th>
                            <th><i class=""fa fa-info-circle"" aria-hidden=""true""></i>    Details</th>
                            <th> <i class=""fa fa-gavel""></i> Action</th>
                        </tr>
                    </thead>

                </table>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(" \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "992ea89300a8fb20b2482de7883e54e9284393f87381", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hospital.Models.SubAdmin.Patients>> Html { get; private set; }
    }
}
#pragma warning restore 1591