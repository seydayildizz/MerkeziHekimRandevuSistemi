#pragma checksum "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\FindAppointment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8030420c86e314417dfcc145871ad335a6c039ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_FindAppointment), @"mvc.1.0.view", @"/Views/Patient/FindAppointment.cshtml")]
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
#line 1 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_EL.IdentityModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_EL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8030420c86e314417dfcc145871ad335a6c039ee", @"/Views/Patient/FindAppointment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af129a036f61b3a4a8b161daaf817a8bb5a0a77", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_FindAppointment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AvailableDoctorAppointmentViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Patient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Appointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FindAppointmentHours", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item list-group-item-action col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" display: flex; justify-content: space-between; height:60px; align-items:center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\FindAppointment.cshtml"
  
    ViewData["Title"] = "FindAppointment";
    Layout = "~/Views/Shared/_LayoutMHRS.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""background-color:#ffffff; border-radius: 18px;"">
    <div class=""container-fluid"">
        <div class=""col-md-12"" style="" border-radius: 12px; padding: 30px; min-height: calc(100vh - 300px);"">
            <div class=""row col-md-12"" style=""font-size:20px"">
                <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8030420c86e314417dfcc145871ad335a6c039ee6683", async() => {
                WriteLiteral("<i class=\"fa fa-arrow-left\" style=\"color:black\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&emsp;Randevu Listesi</span>\r\n");
            WriteLiteral("            </div>\r\n            <div class=\"row col-md-12\" style=\"display: flex; flex-direction: column;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8030420c86e314417dfcc145871ad335a6c039ee8285", async() => {
                WriteLiteral("\r\n                    <span>&ensp;</span>\r\n                    <span>&ensp;</span>\r\n                    <div class=\"list-group\">\r\n\r\n");
#nullable restore
#line 19 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\FindAppointment.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8030420c86e314417dfcc145871ad335a6c039ee9007", async() => {
                    WriteLiteral("\r\n                                <span class=\"col-md-2\">\r\n                                    <i class=\"fa fa-user-md\" aria-hidden=\"true\" style=\"transform:scale(1.5)\"></i>&ensp;\r\n                                    ");
#nullable restore
#line 24 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\FindAppointment.cshtml"
                               Write(item.Doctor.AppUser.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                    ");
#nullable restore
#line 25 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\FindAppointment.cshtml"
                               Write(item.Doctor.AppUser.Surname);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                </span>\r\n                                <strong class=\"col-md-2\">\r\n");
                    WriteLiteral(@"                                    <i class=""fa fa-calendar-check-o"" aria-hidden=""true"" style=""transform:scale(1.3)""></i>
                                    <span style=""background: #fafafa; border: 1px solid #d9d9d9; border-radius: 5px; background-color: rgb(45, 183, 245); color:#fff; padding:5px;"">
                                        ");
#nullable restore
#line 31 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\FindAppointment.cshtml"
                                   Write(DateTime.Now.AddDays(1).ToShortDateString());

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                    </span>\r\n                                </strong>\r\n                                <span class=\"col-md-6\"><i class=\"fa fa-h-square\" aria-hidden=\"true\" style=\"transform:scale(1.3)\"></i>&ensp; ");
#nullable restore
#line 34 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\FindAppointment.cshtml"
                                                                                                                                       Write(item.Hospital.HospitalName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span>\r\n                                <span class=\"col-md-2\"><i class=\"fa fa-hospital-o\" aria-hidden=\"true\" style=\"transform:scale(1.3)\"></i>&ensp; ");
#nullable restore
#line 35 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\FindAppointment.cshtml"
                                                                                                                                         Write(item.Clinic.ClinicName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-hcid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\FindAppointment.cshtml"
                                                                                              WriteLiteral(item.HospitalClinicId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hcid"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-hcid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hcid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\FindAppointment.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AvailableDoctorAppointmentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591