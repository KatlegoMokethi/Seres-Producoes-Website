#pragma checksum "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Artists\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94186d013489a4c32d09838d2074dbb03b7a514a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artists_Details), @"mvc.1.0.view", @"/Views/Artists/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Artists/Details.cshtml", typeof(AspNetCore.Views_Artists_Details))]
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
#line 1 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\_ViewImports.cshtml"
using SeresProducoes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94186d013489a4c32d09838d2074dbb03b7a514a", @"/Views/Artists/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05a7cda0f0998f3a456757346bb5f13661fb68e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Artists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Artist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Artists\Details.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
            BeginContext(61, 55, true);
            WriteLiteral("\r\n<div class=\"container pt-5 pb-3\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(117, 10, false);
#line 9 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Artists\Details.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(127, 104, true);
            WriteLiteral("\r\n    </h1>\r\n    <div>\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 231, "\"", 249, 1);
#line 14 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Artists\Details.cshtml"
WriteAttributeValue("", 237, Model.Image, 237, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(250, 20, true);
            WriteLiteral(" style=\"width:100%;\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 270, "\"", 287, 1);
#line 14 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Artists\Details.cshtml"
WriteAttributeValue("", 276, Model.Name, 276, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(288, 174, true);
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <p>Latest tracks:</p>\r\n                <iframe width=\"400\" height=\"250\" scrolling=\"no\" frameborder=\"0\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 462, "\"", 481, 1);
#line 18 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Artists\Details.cshtml"
WriteAttributeValue("", 468, Model.Tracks, 468, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(482, 177, true);
            WriteLiteral("></iframe>\r\n            </div>\r\n        </div>\r\n        <div class=\"pt-3\">\r\n            <div>\r\n                <p>\r\n                    <b>FOLLOW AT:</b>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 659, "\"", 685, 1);
#line 25 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Artists\Details.cshtml"
WriteAttributeValue("", 666, Model.FacebookLink, 666, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(686, 83, true);
            WriteLiteral("><span class=\"p-1 fab fa-facebook-square fa-2x\"></span></a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 769, "\"", 794, 1);
#line 26 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Artists\Details.cshtml"
WriteAttributeValue("", 776, Model.TwitterLink, 776, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(795, 145, true);
            WriteLiteral("><span class=\"p-1 fab fa-twitter-square fa-2x\"></span></a>\r\n                </p>\r\n            </div>\r\n\r\n            <h4>Bio</h4>\r\n            <p>");
            EndContext();
            BeginContext(941, 9, false);
#line 31 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Artists\Details.cshtml"
          Write(Model.Bio);

#line default
#line hidden
            EndContext();
            BeginContext(950, 40, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Artist> Html { get; private set; }
    }
}
#pragma warning restore 1591
