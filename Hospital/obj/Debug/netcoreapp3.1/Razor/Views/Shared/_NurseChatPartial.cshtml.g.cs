#pragma checksum "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_NurseChatPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "823aa57db6f67ebcf44feb3a1c692523afb450cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NurseChatPartial), @"mvc.1.0.view", @"/Views/Shared/_NurseChatPartial.cshtml")]
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
#line 1 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_ViewImports.cshtml"
using Hospital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_ViewImports.cshtml"
using Hospital.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823aa57db6f67ebcf44feb3a1c692523afb450cf", @"/Views/Shared/_NurseChatPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88caee22214edcd79e48d3dce45ad60c3b27aa44", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34916b9f6fcf84494b7968b2ecb0bba4cc5dc30d", @"/Views/Shared/_ViewImports.cshtml")]
    public class Views_Shared__NurseChatPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hospital.Models.CommonModels.ChatViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-md-12\">\r\n\r\n    <div class=\"dash-widget1\">\r\n");
#nullable restore
#line 5 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_NurseChatPartial.cshtml"
         if (Model.ReciverMessages != null)
        {
            foreach (var item in Model.ReciverMessages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"receiver-block\">\r\n                    <span class=\"dash-widget-bg1\"><i class=\"fa fa-user\" aria-hidden=\"true\"></i></span>\r\n                    <div class=\"dash-widget-info reciv_box\">\r\n                        <h3>");
#nullable restore
#line 12 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_NurseChatPartial.cshtml"
                       Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 13 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_NurseChatPartial.cshtml"
                      Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n");
#nullable restore
#line 17 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_NurseChatPartial.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_NurseChatPartial.cshtml"
         if (Model.SenderMessages != null)
        {
            foreach (var item in Model.SenderMessages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"sender-block\">\r\n                    <span class=\"dash-widget-bg1 receiv_icon\"><i class=\"fa fa-user\" aria-hidden=\"true\"></i></span>\r\n                    <div class=\"dash-widget-info\">\r\n                        <h3>");
#nullable restore
#line 26 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_NurseChatPartial.cshtml"
                       Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 27 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_NurseChatPartial.cshtml"
                      Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n");
#nullable restore
#line 31 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_NurseChatPartial.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n<div class=\"chat_btn_section\">\r\n    <input type=\"hidden\" class=\"SelectedId\"");
            BeginWriteAttribute("value", " value=\"", 1281, "\"", 1308, 1);
#nullable restore
#line 37 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_NurseChatPartial.cshtml"
WriteAttributeValue("", 1289, ViewBag.SelectedId, 1289, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    <div class=""chat_btn_box"">
        <div class=""row"">
            <div class=""col-md-9"">
                <input type=""text"" id=""txtMessage"" placeholder=""Type message...."" class=""form-control"" />
            </div>
            <div class=""col-md-3"">
                <input type=""button"" id=""btnSendMessge"" class=""btn btn-success send_btn"" value=""send"" />
            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $(""#btnSendMessge"").click(function () {
        var id = $("".SelectedId"").val();
        var message = $(""#txtMessage"").val();
        $.ajax({
            type: ""POST"",
            url: """);
#nullable restore
#line 56 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_NurseChatPartial.cshtml"
             Write(Url.Action("SendMessage"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { Id: id,Message:message},
            dataType: ""text"",
            success: function (result) {
                $('#txtMessage').val("""");
            },
            error: function (req, status, error) {
                $('#txtMessage').val("""");
                $.ajax({
            type: ""POST"",
            url: """);
#nullable restore
#line 66 "D:\Bitbu\hospitalmanagement\Hospital\Views\Shared\_NurseChatPartial.cshtml"
             Write(Url.Action("ChatPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { Id:id },
            dataType: ""html"",
            success: function (result) {
                $('#dvUserChat').html(result);
            },
            error: function (req, status, error) {
                console.log(error);
            }
        });
            }
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hospital.Models.CommonModels.ChatViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
