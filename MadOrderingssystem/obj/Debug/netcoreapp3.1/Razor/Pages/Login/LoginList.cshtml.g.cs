#pragma checksum "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "486521ded48d8fc677e521be98298e1b8ea14dcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MadOrderingssystem.Pages.Login.Pages_Login_LoginList), @"mvc.1.0.razor-page", @"/Pages/Login/LoginList.cshtml")]
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
#line 1 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\_ViewImports.cshtml"
using MadOrderingssystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
using MadOrderingssystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"486521ded48d8fc677e521be98298e1b8ea14dcd", @"/Pages/Login/LoginList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71eb8fd009691008332d95b2b2663f10064e33c0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login_LoginList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
  
    ViewData["Title"] = "Login Management";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"">Bruger Tabel</h1>
<p class=""text-center""></p>
<h3>Brugere</h3>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Navn
            </th>
            <th>
                Efternavn
            </th>
            <th>
                Email
            </th>
            <th>
                Telefonnummer
            </th>
            <th>
                Adresse
            </th>
            <th>
                Postnummer
            </th>
            <th>
                Registrerings dato
            </th>
            <th>
                Password
            </th>
            <th>
                Role
            </th>
            <th>
                Kontrol
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 51 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
         foreach (Customer customer in Model.DicC.Values)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
           Write(customer.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
           Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
           Write(customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
           Write(customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
           Write(customer.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
           Write(customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
           Write(customer.PostNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
           Write(customer.Date.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
           Write(customer.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
           Write(customer.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "486521ded48d8fc677e521be98298e1b8ea14dcd8288", async() => {
                WriteLiteral("Redigere");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
                                             WriteLiteral(customer.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "486521ded48d8fc677e521be98298e1b8ea14dcd10483", async() => {
                WriteLiteral("Slet");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
                                               WriteLiteral(customer.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </p>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 91 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Login\LoginList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MadOrderingssystem.Pages.Login.LoginListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MadOrderingssystem.Pages.Login.LoginListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MadOrderingssystem.Pages.Login.LoginListModel>)PageContext?.ViewData;
        public MadOrderingssystem.Pages.Login.LoginListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
