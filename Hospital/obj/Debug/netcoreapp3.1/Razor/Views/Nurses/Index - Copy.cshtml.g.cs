#pragma checksum "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\Index - Copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fefb343f544e9b3dbfa540a28aeac249b179270"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nurses_Index___Copy), @"mvc.1.0.view", @"/Views/Nurses/Index - Copy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fefb343f544e9b3dbfa540a28aeac249b179270", @"/Views/Nurses/Index - Copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88caee22214edcd79e48d3dce45ad60c3b27aa44", @"/Views/_ViewImports.cshtml")]
    public class Views_Nurses_Index___Copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hospital.CollectionViewModel.CollectionOfAll>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bdy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\Index - Copy.cshtml"
   ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_NursesLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fefb343f544e9b3dbfa540a28aeac249b1792703672", async() => {
                WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.0/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js""></script>
<script>
        document.getElementById(""bdy"").onload = function () { myFunction() };

        function myFunction() {
            toastr.success('Login Successful');
        }
</script>
<div class=""content"">
    <div class=""row"">
        <div class=""col-md-6 col-sm-6 col-lg-6 col-xl-3"">
            <div class=""dash-widget"">
                <span class=""dash-widget-bg1""><i class=""fa fa-user-md"" aria-hidden=""true""></i></span>
                <div class=""dash-widget-info text-right"">
                    <h3>");
#nullable restore
#line 24 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\Index - Copy.cshtml"
                   Write(ViewBag.docLists.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                    <span class=""widget-title1"">Doctors <i class=""fa fa-check"" aria-hidden=""true""></i></span>
                </div>
            </div>
        </div>
        <div class=""col-md-6 col-sm-6 col-lg-6 col-xl-3"">
            <div class=""dash-widget"">
                <span class=""dash-widget-bg2""><i class=""fa fa-stethoscope"" aria-hidden=""true""></i></span>
                <div class=""dash-widget-info text-right"">
                    <h3>");
#nullable restore
#line 33 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\Index - Copy.cshtml"
                   Write(ViewBag.nursLists.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                    <span class=""widget-title2"">Nurses <i class=""fa fa-check"" aria-hidden=""true""></i></span>
                </div>
            </div>
        </div>
        <div class=""col-md-6 col-sm-6 col-lg-6 col-xl-3"">
            <div class=""dash-widget"">
                <span class=""dash-widget-bg3""><i class=""fa fa-user-o""></i></span>
                <div class=""dash-widget-info text-right"">
                    <h3>");
#nullable restore
#line 42 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\Index - Copy.cshtml"
                   Write(Model.Patients.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                    <span class=""widget-title3"">Patients <i class=""fa fa-check"" aria-hidden=""true""></i></span>
                </div>
            </div>
        </div>


        <div class=""col-md-6 col-sm-6 col-lg-6 col-xl-3"">
            <div class=""dash-widget"">
                <span class=""dash-widget-bg4""><i class=""fa fa-calendar"" aria-hidden=""true""></i></span>
                <div class=""dash-widget-info text-right"">
                    <h3>");
#nullable restore
#line 53 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\Index - Copy.cshtml"
                   Write(Model.Appointments.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                    <span class=""widget-title4"">Appointment <i class=""fa fa-check"" aria-hidden=""true""></i></span>
                </div>
            </div>
        </div>
        <div class=""col-md-6 col-sm-6 col-lg-6 col-xl-3"">
            <div class=""dash-widget"">
                <span class=""dash-widget-bg4""><i class=""fa fa-bed"" aria-hidden=""true""></i></span>
                <div class=""dash-widget-info text-right"">
                    <h3>");
#nullable restore
#line 62 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\Index - Copy.cshtml"
                   Write(Model.Allotments.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                    <span class=""widget-title4"">Allotment <i class=""fa fa-check"" aria-hidden=""true""></i></span>
                </div>
            </div>
        </div>
        <div class=""col-md-6 col-sm-6 col-lg-6 col-xl-3"">
            <div class=""dash-widget"">
                <span class=""dash-widget-bg3""><i class=""fa fa-hospital-o"" aria-hidden=""true""></i></span>
                <div class=""dash-widget-info text-right"">
                    <h3>");
#nullable restore
#line 71 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\Index - Copy.cshtml"
                   Write(Model.Department.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                    <span class=""widget-title3"">Department <i class=""fa fa-check"" aria-hidden=""true""></i></span>
                </div>
            </div>
        </div>
        <div class=""col-md-6 col-sm-6 col-lg-6 col-xl-3"">
            <div class=""dash-widget"">
                <span class=""dash-widget-bg2""><i class=""fa fa-calendar-check-o"" aria-hidden=""true""></i></span>
                <div class=""dash-widget-info text-right"">
                    <h3>");
#nullable restore
#line 80 "D:\Bitbu\hospitalmanagement\Hospital\Views\Nurses\Index - Copy.cshtml"
                   Write(Model.Schedules.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    <span class=\"widget-title2\">Schedules <i class=\"fa fa-check\" aria-hidden=\"true\"></i></span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hospital.CollectionViewModel.CollectionOfAll> Html { get; private set; }
    }
}
#pragma warning restore 1591
