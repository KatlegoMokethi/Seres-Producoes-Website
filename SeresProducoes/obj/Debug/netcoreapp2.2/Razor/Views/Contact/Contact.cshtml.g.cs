#pragma checksum "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\Re-work\SeresProducoes\Views\Contact\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85612e37cfc0608875d9c854bb5c8ec6d82a4e12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Contact), @"mvc.1.0.view", @"/Views/Contact/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Contact.cshtml", typeof(AspNetCore.Views_Contact_Contact))]
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
#line 1 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\Re-work\SeresProducoes\Views\_ViewImports.cshtml"
using SeresProducoes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85612e37cfc0608875d9c854bb5c8ec6d82a4e12", @"/Views/Contact/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05a7cda0f0998f3a456757346bb5f13661fb68e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\Re-work\SeresProducoes\Views\Contact\Contact.cshtml"
  
    ViewData["Title"] = "Contact us";

#line default
#line hidden
            BeginContext(46, 4493, true);
            WriteLiteral(@"<!-- TO DO: FORM and FORM VALIDATION -->
<div class=""container pb-3"">
    <div class=""text-center"">
        <h1 class=""display-4 text-primary"">Contact us</h1>
    </div>

    <section class=""contact-section my-5 text-dark"">
        <!-- Grid row -->
        <div class=""row"">
            <!-- Grid column -->
            <div class=""col-lg-8 text-white"" style=""background-image: url('/images/footer.jpg'); width:50%"">
                <div class=""card-body form"">
                    <!-- Header -->
                    <h3 class=""mt-4""><i class=""fas fa-envelope pr-2""></i>Write to us:</h3>
                    <!-- Grid row -->
                    <div class=""row"">
                        <!-- Grid column -->
                        <div class=""col-md-6"">
                            <div class=""md-form mb-0"">
                                <input type=""text"" id=""form-contact-name"" class=""form-control"">
                                <label for=""form-contact-name"" class="""">Your name</label>
    ");
            WriteLiteral(@"                        </div>
                        </div>
                        <!-- Grid column -->
                        <!-- Grid column -->
                        <div class=""col-md-6"">
                            <div class=""md-form mb-0"">
                                <input type=""text"" id=""form-contact-email"" class=""form-control"">
                                <label for=""form-contact-email"" class="""">Your email</label>
                            </div>
                        </div>
                        <!-- Grid column -->

                    </div>
                    <!-- Grid row -->
                    <!-- Grid row -->
                    <div class=""row"">
                        <!-- Grid column -->
                        <div class=""col-md-6"">
                            <div class=""md-form mb-0"">
                                <input type=""text"" id=""form-contact-phone"" class=""form-control"">
                                <label for=""form-contact-phone"" ");
            WriteLiteral(@"class="""">Your phone</label>
                            </div>
                        </div>
                        <!-- Grid column -->
                        <!-- Grid column -->
                        <div class=""col-md-6"">
                            <div class=""md-form mb-0"">
                                <input type=""text"" id=""form-contact-company"" class=""form-control"">
                                <label for=""form-contact-company"" class="""">Your company</label>
                            </div>
                        </div>
                        <!-- Grid column -->

                    </div>
                    <!-- Grid row -->
                    <!-- Grid row -->
                    <div class=""row"">
                        <!-- Grid column -->
                        <div class=""col-md-12"">
                            <div class=""md-form mb-0"">
                                <textarea id=""form-contact-message"" class=""form-control md-textarea"" rows=""3""></textarea>");
            WriteLiteral(@"
                                <label for=""form-contact-message"">Your message</label>
                                <a class=""btn-floating btn-lg blue"">
                                    <i class=""far fa-paper-plane""></i>
                                </a>
                            </div>
                        </div>
                        <!-- Grid column -->
                    </div>
                    <!-- Grid row -->
                </div>
            </div>
            <!-- Grid column -->
            <!-- Grid column -->
            <div class=""col-lg-4 bg-dark text-white"" style=""background-image: url('/images/gallery/19.png'); width:100%"">
                <div class=""card-body contact text-center h-100 white-text"">

                    <h3 class=""my-4 pb-2"">Contact information</h3>
                    <p>
                        For general info, licensing or to send your demos, please write to:
                    </p>
                    <h5>
                     ");
            WriteLiteral(@"   <span class=""fas fa-envelope pr-2""></span>
                        <a href=""mailto:info@seresproducoes.com?"">info@seresproducoes.com</a>
                    </h5>

                    <hr class=""hr-light my-4"">
                </div>
            </div>
            <!-- Grid column -->
        </div>
        <!-- Grid row -->
        <!-- Form with header -->
    </section>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
