#pragma checksum "C:\Users\SRT\source\repos\Vesperr\Vesperr\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc69219c6595f68ff6db74906c952246d2ef8bec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
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
#line 1 "C:\Users\SRT\source\repos\Vesperr\Vesperr\Views\_ViewImports.cshtml"
using Vesper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SRT\source\repos\Vesperr\Vesperr\Views\_ViewImports.cshtml"
using Vesper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc69219c6595f68ff6db74906c952246d2ef8bec", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eafd6a71cface81a85b6d87a95f3db1f8fcf048", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TeamMember>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SRT\source\repos\Vesperr\Vesperr\Views\Team\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
<section id=""team"" class=""team section-bg"">
    <div class=""container"">

        <div class=""section-title aos-init aos-animate"" data-aos=""fade-up"">
            <h2>Team</h2>
            <p>Necessitatibus eius consequatur ex aliquid fuga eum quidem</p>
        </div>

        <div class=""row"">

");
#nullable restore
#line 17 "C:\Users\SRT\source\repos\Vesperr\Vesperr\Views\Team\Index.cshtml"
                 foreach(var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"">
                        <div class=""member aos-init aos-animate"" data-aos=""fade-up"" data-aos-delay=""100"">
                            <div class=""member-img"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fc69219c6595f68ff6db74906c952246d2ef8bec4471", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 729, "~/assets/img/team/", 729, 18, true);
#nullable restore
#line 22 "C:\Users\SRT\source\repos\Vesperr\Vesperr\Views\Team\Index.cshtml"
AddHtmlAttributeValue("", 747, item.Image, 747, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"social\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 861, "\"", 868, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-twitter\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 943, "\"", 950, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-facebook\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1026, "\"", 1033, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-instagram\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1110, "\"", 1117, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-linkedin\"></i></a>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"member-info\">\r\n                                <h4>");
#nullable restore
#line 31 "C:\Users\SRT\source\repos\Vesperr\Vesperr\Views\Team\Index.cshtml"
                               Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <span>");
#nullable restore
#line 32 "C:\Users\SRT\source\repos\Vesperr\Vesperr\Views\Team\Index.cshtml"
                                 Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 34 "C:\Users\SRT\source\repos\Vesperr\Vesperr\Views\Team\Index.cshtml"
                               Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 39 "C:\Users\SRT\source\repos\Vesperr\Vesperr\Views\Team\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n\r\n            \r\n\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TeamMember>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
