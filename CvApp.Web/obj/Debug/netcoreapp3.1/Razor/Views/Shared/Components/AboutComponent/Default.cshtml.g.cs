#pragma checksum "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\Shared\Components\AboutComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d3f75ce64d69e42a5a660ac67447464632bb760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d3f75ce64d69e42a5a660ac67447464632bb760", @"/Views/Shared/Components/AboutComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bae41164b1080f182ce89a9fca45175523832f63", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AboutComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CvApp.DTO.DTOs.AppUserDtos.AppUserListDto>
    {
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
        private global::CvApp.Web.TagHelpers.SocialMediaIconTagHelper __CvApp_Web_TagHelpers_SocialMediaIconTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"resume-section\" id=\"about\">\r\n    <div class=\"resume-section-content\">\r\n        <h1 class=\"mb-0\">\r\n            ");
#nullable restore
#line 6 "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\Shared\Components\AboutComponent\Default.cshtml"
       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"text-primary\">");
#nullable restore
#line 7 "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\Shared\Components\AboutComponent\Default.cshtml"
                                  Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </h1>\r\n        <div class=\"subheading mb-5\">\r\n            ");
#nullable restore
#line 10 "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\Shared\Components\AboutComponent\Default.cshtml"
       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" · ");
#nullable restore
#line 10 "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\Shared\Components\AboutComponent\Default.cshtml"
                        Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ·\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 378, "\"", 404, 2);
            WriteAttributeValue("", 385, "mailto:", 385, 7, true);
#nullable restore
#line 11 "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\Shared\Components\AboutComponent\Default.cshtml"
WriteAttributeValue("", 392, Model.Email, 392, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\Shared\Components\AboutComponent\Default.cshtml"
                                     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </div>\r\n        <p class=\"lead mb-5\">");
#nullable restore
#line 13 "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\Shared\Components\AboutComponent\Default.cshtml"
                        Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n      \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("geticons", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d3f75ce64d69e42a5a660ac67447464632bb7605618", async() => {
            }
            );
            __CvApp_Web_TagHelpers_SocialMediaIconTagHelper = CreateTagHelper<global::CvApp.Web.TagHelpers.SocialMediaIconTagHelper>();
            __tagHelperExecutionContext.Add(__CvApp_Web_TagHelpers_SocialMediaIconTagHelper);
#nullable restore
#line 15 "C:\Users\ÖmerÖzkan\source\repos\CvApp\CvApp.Web\Views\Shared\Components\AboutComponent\Default.cshtml"
__CvApp_Web_TagHelpers_SocialMediaIconTagHelper.AppUserId = Model.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("app-user-id", __CvApp_Web_TagHelpers_SocialMediaIconTagHelper.AppUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CvApp.DTO.DTOs.AppUserDtos.AppUserListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
