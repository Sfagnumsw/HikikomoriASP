#pragma checksum "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7af1cf3cf7a713a66bacc51d2defaec65c996356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_ListBooks), @"mvc.1.0.view", @"/Views/Content/ListBooks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af1cf3cf7a713a66bacc51d2defaec65c996356", @"/Views/Content/ListBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6271029b7f4682b79993f740eb8ec192b2381dca", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_ListBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Content>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7af1cf3cf7a713a66bacc51d2defaec65c9963563393", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Books</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7af1cf3cf7a713a66bacc51d2defaec65c9963564452", async() => {
                WriteLiteral(@"
    <input type=""button"" value=""DELETE"" class=""delete-button"">
    <table class=""table-list-rate"">
        <caption>Прочитал</caption>
        <thead>
            <tr><th>Id</th><th>Название</th><th>Жанр</th><th>Автор</th><th>Год создания</th><th>Оценка</th></tr>
        </thead>
        <tbody>
");
#nullable restore
#line 14 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
             foreach (var i in (List<Content>)ViewBag.listRate)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr><td>");
#nullable restore
#line 16 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
                   Write(i.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 16 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
                                 Write(i.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 16 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
                                                 Write(i.Genre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 16 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
                                                                  Write(i.Autor);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 16 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
                                                                                   Write(i.CreationYear);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 16 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
                                                                                                           Write(i.Rating);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 17 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </tbody>
    </table>

    <br>
    <table class=""table-list-remember"">
        <caption>Прочитаю позже</caption>
        <thead>
            <tr><th>Id</th><th>Название</th><th>Жанр</th><th>Автор</th><th>Год создания</th></tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
             foreach (var i in (List<Remember>)ViewBag.listRemember)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr><td>");
#nullable restore
#line 30 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
                   Write(i.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 30 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
                                 Write(i.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 30 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
                                                 Write(i.Genre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 30 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
                                                                  Write(i.Autor);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 30 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
                                                                                   Write(i.CreationYear);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 31 "C:\Users\Sfagnum\Documents\обучение\Программирование\C#\eaxDeskTop\HikomoriASP\HikikomoriWEB\Views\Content\ListBooks.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
