#pragma checksum "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\Appointment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e82611cc3602d2a7e79fa573160a76c598b8bc04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Appointment), @"mvc.1.0.view", @"/Views/Patient/Appointment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e82611cc3602d2a7e79fa573160a76c598b8bc04", @"/Views/Patient/Appointment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e6353e1e6dc0fe8bff72cf424266c033fecdd13", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_Appointment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Patient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveAppointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\Appointment.cshtml"
  
    ViewData["Title"] = "Appointment";
    Layout = "~/Views/Shared/_LayoutMHRS.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
            WriteLiteral("</div>\r\n<div class=\"row\" style=\"background-color:whitesmoke; border-radius:4px; padding:10px\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e82611cc3602d2a7e79fa573160a76c598b8bc045525", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <span class=""text-danger"" style=""font-weight:bold;margin-right:3px""> * </span>
                <label for=""City"" style=""font-weight:bold"">İL</label>
                <select id=""CitySelect"" name=""City"" class=""form-control"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e82611cc3602d2a7e79fa573160a76c598b8bc046098", async() => {
                    WriteLiteral("**İl Seçiniz**");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\Appointment.cshtml"
                     foreach (var item in ViewBag.Cities)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e82611cc3602d2a7e79fa573160a76c598b8bc047969", async() => {
#nullable restore
#line 19 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\Appointment.cshtml"
                                            Write(item.CityName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\Appointment.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\Appointment.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </select>

            </div>
            <div class=""form-group"">
                <span class=""text-danger"" style=""font-weight:bold;margin-right:3px""> * </span>
                <label for=""District"" style=""font-weight:bold"">İLÇE</label>
                <select id=""DistrictSelect"" name=""District"" class=""form-control"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e82611cc3602d2a7e79fa573160a76c598b8bc0410482", async() => {
                    WriteLiteral("***İlçe Seçiniz***");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>
            <div class=""form-group"">
                <span class=""text-danger"" style=""font-weight:bold;margin-right:3px""> * </span>
                <label for=""Clinic"" style=""font-weight:bold"">KLİNİK</label>
                <select id=""ClinicSelect"" name=""Clinic"" class=""form-control"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e82611cc3602d2a7e79fa573160a76c598b8bc0412413", async() => {
                    WriteLiteral("***Klinik Seçiniz***");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\Appointment.cshtml"
                     foreach (var item in ViewBag.Clinics)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e82611cc3602d2a7e79fa573160a76c598b8bc0414292", async() => {
#nullable restore
#line 39 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\Appointment.cshtml"
                                            Write(item.ClinicName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\Appointment.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\103SABAH_ŞEYDA\source\repos\MHRSLiteCore\MHRSLite_UI\Views\Patient\Appointment.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>

            </div>
            <div class=""form-group"">
                <span class=""text-danger"" style=""font-weight:bold;margin-right:3px""> * </span>
                <label for=""Hospital"" style=""font-weight:bold"">HASTANE</label>
                <select id=""HospitalSelect"" name=""Hospital"" class=""form-control"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e82611cc3602d2a7e79fa573160a76c598b8bc0416809", async() => {
                    WriteLiteral("***Hastane Seçiniz***");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>
            <div class=""col-md-12"">
                <div class=""col-md-6"" style=""float:left"">
                    <input id=""randevuAra"" value=""Randevu Ara"" class=""btn btn-block btn-default"" type=""button"" style=""background-color:white; color:red;border:1px solid red"" />

                </div>
                <div class=""col-md-6"" style=""float:right"">
                    <input id=""Temizle"" value=""Temizle"" class=""btn btn-block btn-default"" type=""button"" style=""background-color:red; color:white;"" />
                </div>
            </div>

        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //CitySelect combodan il seçildiğinde bu fonk çalışacak
        //change event
        $('#CitySelect').on('change', function () {
            //ilçe combosunu temizler ve içerisine ilk değerini atar
            var $dropdown = $(""#DistrictSelect"");
            $dropdown.empty();
            $dropdown.append(""<option selected value='0'>***İlçe Seçiniz***</option>"");
            //il değiştiği anda hastane combosu temizlensin ve ilk değeri(***Hastane Seçiniz***) atansın
            var $dropdown = $(""#HospitalSelect"");
            $dropdown.empty();
            $dropdown.append(""<option selected value='0'>***Hastane Seçiniz***</option>"");

            //il değiştiğinde clinic resetlensin
            $('#ClinicSelect')
                .val(0)
                .trigger('change');

            //hangi ilin seçili olduğunu değişkene aldık
            var cityId = this.value;
            //il combosundan seçilen değer 0dan büyükse gerçekten bir il seçildiyse aşağıdaki metot");
                WriteLiteral(@"a gitsin
            //böylece İle ait ilçeleri getirmiş olur.
            if (cityId > 0) {
                $.ajax({
                    type: ""GET"",
                    url: '/City/GetCityDistricts/' + cityId,
                    success: function (res) {
                        
                        var $dropdown = $(""#DistrictSelect"");
                        $dropdown.empty();
                        $dropdown.append(""<option selected value='0'>***İlçe Seçiniz***</option>"");
                        //bu bir jquery foreach döngüsüdür
                        //gelen json sonucunun her birini ilçe combosuna ekler
                        $.each(res.data, function () {
                            $dropdown.append($(""<option />"").val(this.id).text(this.districtName));
                        });
                    },
                    error: function (err) {
                        console.log(err);
                    },
                });
            }
        });
        //ilçe");
                WriteLiteral(@" combodan ilçe seçildiğinde bu fonk çalışacak
        //change event
        $('#DistrictSelect').on('change', function () {
            //hangi ilçenin seçildiğini değişkene atadık belki işimize yararsa diye
            var districtid = this.value;
            //ilçe değiştiğinde hastane combosunun içini temizle ve ilk değerini ata
            var $dropdown = $(""#HospitalSelect"");
            $dropdown.empty();
            $dropdown.append(""<option selected value='0'>***Hastane Seçiniz***</option>"");
            $('#ClinicSelect')
                .val(0)
                .trigger('change');
        });

        //klinik seçildiğinde bu fonk çalışacak
        $('#ClinicSelect').on('change', function () {
            //hangi kliniğin seçili olduğu değişkeni aldık
            var clinicid = this.value;
            //hangi ilçenin seçili olduğunu değişkene aldık
            var districtid = $('#DistrictSelect').val();
            //hastane combosu temizlenip ilk değeri atandı
            var ");
                WriteLiteral(@"$dropdown = $(""#HospitalSelect"");
            $dropdown.empty();
            $dropdown.append(""<option selected value='0'>***Hastane Seçiniz***</option>"");
            //seçilen kliniğin value değeri 0dan büyükse o ilçedeki o kliniklere sahip hastaneleri getirecek
            if (clinicid > 0) {
                $.ajax({
                    type: ""GET"",
                    url: '/Hospital/GetHospitalFromClinicId?id=' + clinicid + ""&districtid="" + districtid,
                    success: function (res) {
                        //json ile gelen hastaneler hastane combosuna eklendi. (Jqoery foreach döngüsü)
                        console.log(res.data);
                        $.each(res.data, function () {
                            $dropdown.append($(""<option />"").val(this.id).text(this.hospitalName));
                        });
                    },
                    error: function (err) {
                        console.log(err);
                    },
                });
           ");
                WriteLiteral(@" }

        });
        //Hastane seçildiğinde bu fonk çalışır (change event)
        $('#HospitalSelect').on('change', function () {
            var id = this.value;
        });
        //Temizle butonu temizlik yapacak
        $('#Temizle').on('click', function () {
            //iller combosunda ""il seçiniz"" seçili hale gelsin
            $('#CitySelect')
                .val(0)
                .trigger('change');
        });
        //randevuAra butonuna tıklandığında seçili hastane ve kliniğe ait müsait randevular ekrana gelecek
        $('#randevuAra').on('click', function () {
            //seçili ilin Idsi
            var cityid = $(""#CitySelect"").val();
            //seçili ilçenin Idsi
            var distid = $(""#DistrictSelect"").val();
            //seçili hospitalın Idsi
            var hid = $(""#HospitalSelect"").val();
            //seçili kliniğin Idsi
            var cid = $(""#ClinicSelect"").val();

            //seçili doktorun Idsi
            /*var dr  = $(""#Doctor");
                WriteLiteral(@"Select"").val();*/


            //yeni pencerede müsait randevular listelenecek
            //il* ilçe klinik* hastane hekim
            //window.open(
            //    '/Patient/FindAppointment?cityid=' + cityid + '&distid=' + distid + '&cid=' + cid + '&hid=' + hid + '&dr=' + dr);

            window.open(
                '/Patient/FindAppointment?cityid=' + cityid + '&distid=' + distid + '&cid=' + cid + '&hid=' + hid, ""_self"");

        });

    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
