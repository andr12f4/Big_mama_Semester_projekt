#pragma checksum "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2b8940126ad9313127fbc11003c47f7cc434d35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MadOrderingssystem.Pages.Login.Pages_Login_Profil), @"mvc.1.0.razor-page", @"/Pages/Login/Profil.cshtml")]
namespace MadOrderingssystem.Pages.Login
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
#line 1 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\_ViewImports.cshtml"
using MadOrderingssystem;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2b8940126ad9313127fbc11003c47f7cc434d35", @"/Pages/Login/Profil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71eb8fd009691008332d95b2b2663f10064e33c0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login_Profil : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
  
    ViewData["Title"] = "Profil";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 8 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
     if(Model.CustomerSession != null)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"text-center\">Din profil</h2>\r\n    <div class=\"border\"></div>\r\n    <h4>");
#nullable restore
#line 13 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
   Write(Model.CustomerSession.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
                               Write(Model.CustomerSession.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <i>lavet d. ");
#nullable restore
#line 14 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
           Write(Model.CustomerSession.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n    <p>Bor i ");
#nullable restore
#line 15 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
        Write(Model.CustomerSession.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 15 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
                                        Write(Model.CustomerSession.PostNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Dit Telefonnummer: ");
#nullable restore
#line 16 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
                     Write(Model.CustomerSession.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Din email: ");
#nullable restore
#line 17 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
             Write(Model.CustomerSession.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>med rolen ");
#nullable restore
#line 18 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
            Write(Model.CustomerSession.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <i>ID:");
#nullable restore
#line 19 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
     Write(Model.CustomerSession.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n");
#nullable restore
#line 20 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
    } else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>");
#nullable restore
#line 22 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
       Write(Model.exeptionMSG);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 23 "C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\Profil.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MadOrderingssystem.Pages.Login.ProfilModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MadOrderingssystem.Pages.Login.ProfilModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MadOrderingssystem.Pages.Login.ProfilModel>)PageContext?.ViewData;
        public MadOrderingssystem.Pages.Login.ProfilModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
