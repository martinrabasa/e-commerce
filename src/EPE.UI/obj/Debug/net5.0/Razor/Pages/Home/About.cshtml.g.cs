#pragma checksum "C:\Users\marti\projects\epe\src\EPE.UI\Pages\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92c9cbc61cd7062c44bb916513211fd2876ff470"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EPE.UI.Pages.Home.Pages_Home_About), @"mvc.1.0.razor-page", @"/Pages/Home/About.cshtml")]
namespace EPE.UI.Pages.Home
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
#line 1 "C:\Users\marti\projects\epe\src\EPE.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92c9cbc61cd7062c44bb916513211fd2876ff470", @"/Pages/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c4232fd30d10e1c75c96bd67b3cd094c04e2b4a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Home_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\marti\projects\epe\src\EPE.UI\Pages\Home\About.cshtml"
   
    ViewData["Title"] = "Estudio | ";
    ViewData["Section"] = "ESTUDIO";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"projects-container\">\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EPE.UI.Pages.Home.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EPE.UI.Pages.Home.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EPE.UI.Pages.Home.AboutModel>)PageContext?.ViewData;
        public EPE.UI.Pages.Home.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
