#pragma checksum "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\Shared\Components\SkillComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4601ce333efe0d2eeb3972653689f49e10a118d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SkillComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SkillComponent/Default.cshtml")]
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
#line 1 "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\_ViewImports.cshtml"
using CvApp.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\_ViewImports.cshtml"
using CvApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4601ce333efe0d2eeb3972653689f49e10a118d1", @"/Views/Shared/Components/SkillComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bae41164b1080f182ce89a9fca45175523832f63", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SkillComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CvApp.DTO.DTOs.SkillDtos.SkillListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<section class=\"resume-section\" id=\"skills\">\n    <div class=\"resume-section-content\">\n        <h2 class=\"mb-5\">Yetenekler</h2>\n\n    <ul class=\"fa-ul mb-0\">\n");
#nullable restore
#line 8 "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\Shared\Components\SkillComponent\Default.cshtml"
         foreach (var skill in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\n                <span class=\"fa-li\"><i class=\"fas fa-check\"></i></span>\n                ");
#nullable restore
#line 12 "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\Shared\Components\SkillComponent\Default.cshtml"
           Write(skill.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </li>\n");
#nullable restore
#line 14 "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\Shared\Components\SkillComponent\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </ul>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CvApp.DTO.DTOs.SkillDtos.SkillListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
