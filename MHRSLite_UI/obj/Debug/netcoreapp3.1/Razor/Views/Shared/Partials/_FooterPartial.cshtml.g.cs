#pragma checksum "C:\Users\103SABAH_ŞEYDA\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Shared\Partials\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64a6bd91d123f9cfd1ab46560a4f4e17cb8775f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__FooterPartial), @"mvc.1.0.view", @"/Views/Shared/Partials/_FooterPartial.cshtml")]
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
#line 1 "C:\Users\103SABAH_ŞEYDA\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\103SABAH_ŞEYDA\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\103SABAH_ŞEYDA\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\103SABAH_ŞEYDA\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_EL.IdentityModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\103SABAH_ŞEYDA\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_EL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\103SABAH_ŞEYDA\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_EL.PagingListModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64a6bd91d123f9cfd1ab46560a4f4e17cb8775f7", @"/Views/Shared/Partials/_FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49debe6ed7d397e032a075cd5c4f67865b73b803", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("mail-to", "networkacademy@gmail.com", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::MHRSLite_UI.CustomTagHalper.MailTagHelper __MHRSLite_UI_CustomTagHalper_MailTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Start Footer -->
<footer class=""footer-box"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <p class=""footer-company-name"">Tüm Hakları NetworkAcademy Saklıdır. &copy; 2022 
                <a href=""/Home/Index""> MHRS - Merkezi Hekim Randevu Sistemi</a></p>
            </div>
        </div>
        <div class=""row"">
            <a href=""networkacademy@gmail.com"">networkacademy@gmail.com</a>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("myemail", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64a6bd91d123f9cfd1ab46560a4f4e17cb8775f74883", async() => {
                WriteLiteral("Mail Gönder");
            }
            );
            __MHRSLite_UI_CustomTagHalper_MailTagHelper = CreateTagHelper<global::MHRSLite_UI.CustomTagHalper.MailTagHelper>();
            __tagHelperExecutionContext.Add(__MHRSLite_UI_CustomTagHalper_MailTagHelper);
            __MHRSLite_UI_CustomTagHalper_MailTagHelper.MailTo = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</footer>\r\n<!-- End Footer -->\r\n");
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
