#pragma checksum "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Shared\FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3891c916588d04c3b7518ad18c4f5c26d84b3ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FooterPartial), @"mvc.1.0.view", @"/Views/Shared/FooterPartial.cshtml")]
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
#line 2 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\_ViewImports.cshtml"
using HikikomoriWEB.MVC.HelperClass;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\_ViewImports.cshtml"
using HikikomoriWEB.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3891c916588d04c3b7518ad18c4f5c26d84b3ca", @"/Views/Shared/FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6271029b7f4682b79993f740eb8ec192b2381dca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Content>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<footer class=\"copyright\">\r\n    <ul class=\"list-inline\">\r\n        <li>");
#nullable restore
#line 4 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Shared\FooterPartial.cshtml"
       Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"list-inline-item\"><a href=\"#\">VK</a></li>\r\n        <li class=\"list-inline-item\"><a href=\"#\">TG</a></li>\r\n        <li class=\"list-inline-item\"><a href=\"#\">Support</a></li>\r\n    </ul>\r\n</footer>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Content> Html { get; private set; }
    }
}
#pragma warning restore 1591
