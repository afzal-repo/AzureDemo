#pragma checksum "C:\Training\Microsoft-Certifications\AZ_Demos\GIT_Code\AzureDemo\AzureDemo\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87f13de40d6b949ff54865a9acca5d2ff9d81ad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AzureDemo.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AzureDemo.Pages
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
#line 1 "C:\Training\Microsoft-Certifications\AZ_Demos\GIT_Code\AzureDemo\AzureDemo\Pages\_ViewImports.cshtml"
using AzureDemo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87f13de40d6b949ff54865a9acca5d2ff9d81ad5", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931f0246984a3b43ec18de1ed6593f075c98a967", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Training\Microsoft-Certifications\AZ_Demos\GIT_Code\AzureDemo\AzureDemo\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>Azure App Service Demo by Afzal</h1>\r\n    <hr/>\r\n</div>\r\n<div>\r\n        <h4>AppSettings key1 Value == ");
#nullable restore
#line 12 "C:\Training\Microsoft-Certifications\AZ_Demos\GIT_Code\AzureDemo\AzureDemo\Pages\Index.cshtml"
                                 Write(ViewData["key1"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>AppSettings key2 Value == ");
#nullable restore
#line 13 "C:\Training\Microsoft-Certifications\AZ_Demos\GIT_Code\AzureDemo\AzureDemo\Pages\Index.cshtml"
                                 Write(ViewData["key2"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>AppSettings key3 Value == ");
#nullable restore
#line 14 "C:\Training\Microsoft-Certifications\AZ_Demos\GIT_Code\AzureDemo\AzureDemo\Pages\Index.cshtml"
                                 Write(ViewData["key3"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>DB Connectionstring Value == ");
#nullable restore
#line 15 "C:\Training\Microsoft-Certifications\AZ_Demos\GIT_Code\AzureDemo\AzureDemo\Pages\Index.cshtml"
                                    Write(ViewData["connectionString"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
