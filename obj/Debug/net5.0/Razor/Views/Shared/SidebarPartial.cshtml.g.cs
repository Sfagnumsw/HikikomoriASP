#pragma checksum "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Shared\SidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1db4c3004ae4e66c4071175c9c2536f67ae2e09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SidebarPartial), @"mvc.1.0.view", @"/Views/Shared/SidebarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1db4c3004ae4e66c4071175c9c2536f67ae2e09", @"/Views/Shared/SidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6271029b7f4682b79993f740eb8ec192b2381dca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Content>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-4 col-12-medium\">\r\n    <section class=\"sidebar\">\r\n        <h2>Случайная цитата</h2>\r\n        <ul class=\"small-image-list\">         \r\n              <li>\r\n                    <h4>");
#nullable restore
#line 7 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Shared\SidebarPartial.cshtml"
                   Write(ViewData["Character"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h4>");
#nullable restore
#line 8 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Shared\SidebarPartial.cshtml"
                   Write(ViewData["Quote"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h5>");
#nullable restore
#line 9 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Shared\SidebarPartial.cshtml"
                   Write(ViewData["Show"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n              </li>\r\n              <li>\r\n                    <a href=\"#\"><img src=\"images/pic1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 420, "\"", 426, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"left\" /></a>\r\n                    <h4>James Doe</h4>\r\n                    <p>Vitae magna eget odio amet mollis justo facilisis amet quis. Sed sagittis consequat.</p>\r\n              </li>\r\n        </ul>\r\n    </section>\r\n</div>");
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
