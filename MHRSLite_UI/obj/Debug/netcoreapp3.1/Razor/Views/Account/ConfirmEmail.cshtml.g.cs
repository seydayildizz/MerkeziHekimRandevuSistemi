#pragma checksum "C:\Users\103SABAH_ŞEYDA\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac72efac2b82221e097566f523739357c8fe3cdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ConfirmEmail), @"mvc.1.0.view", @"/Views/Account/ConfirmEmail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac72efac2b82221e097566f523739357c8fe3cdb", @"/Views/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49debe6ed7d397e032a075cd5c4f67865b73b803", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\103SABAH_ŞEYDA\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "ConfirmEmail";
    Layout = "~/Views/Shared/_LayoutAccountMHRS.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\103SABAH_ŞEYDA\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Account\ConfirmEmail.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.EmailConfirmedMessage))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"text-danger\">");
#nullable restore
#line 9 "C:\Users\103SABAH_ŞEYDA\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Account\ConfirmEmail.cshtml"
                       Write(ViewBag.EmailConfirmedMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 10 "C:\Users\103SABAH_ŞEYDA\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Account\ConfirmEmail.cshtml"
}

#line default
#line hidden
#nullable disable
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
