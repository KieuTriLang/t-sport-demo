#pragma checksum "C:\Users\DELL\source\repos\TSport\TSport\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f17f806576a7f741961214391571b5ef04d11be1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "C:\Users\DELL\source\repos\TSport\TSport\Views\_ViewImports.cshtml"
using TSport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\TSport\TSport\Views\_ViewImports.cshtml"
using TSport.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f17f806576a7f741961214391571b5ef04d11be1", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2db19d8a399165670825f5eba2e6b7e86feec8e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://whizthemes.com/mail-php/raju/arden/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DELL\source\repos\TSport\TSport\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--== Start Page Header Area Wrapper ==-->
<div class=""page-header-area"" data-bg-img=""assets/img/photos/bg3.webp"">
    <div class=""container pt--0 pb--0"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""page-header-content"">
                    <h2 class=""title"" data-aos=""fade-down"" data-aos-duration=""1000"">Contact Us</h2>
                    <nav class=""breadcrumb-area"" data-aos=""fade-down"" data-aos-duration=""1200"">
                        <ul class=""breadcrumb"">
                            <li><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-sep"">//</li>
                            <li>Contact Us</li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>
<!--== End Page Header Area Wrapper ==-->
<!--== Start Contact Area Wrapper ==-->
<section class=""contact-area contact-page-area"">
    <div class=""container"">
        <div class=""row");
            WriteLiteral(@" contact-page-wrapper"">
            <div class=""col-xl-9"">
                <div class=""contact-form-wrap"" data-aos=""fade-right"">
                    <div class=""contact-form-title"">
                        <h2 class=""title"">We Are Here! <br>Please Send A Quest</h2>
                    </div>
                    <!--== Start Contact Form ==-->
                    <div class=""contact-form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f17f806576a7f741961214391571b5ef04d11be15968", async() => {
                WriteLiteral(@"
                            <div class=""row row-gutter-20"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <input class=""form-control"" type=""text"" name=""con_name"" placeholder=""Name *"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <input class=""form-control"" type=""email"" name=""con_email"" placeholder=""Email *"">
                                    </div>
                                </div>
                                <div class=""col-12"">
                                    <div class=""form-group"">
                                        <input class=""form-control"" type=""text"" placeholder=""Subject (Optinal)"">
                                    </div>
                                </div>
  ");
                WriteLiteral(@"                              <div class=""col-12"">
                                    <div class=""form-group mb--0"">
                                        <textarea class=""form-control"" name=""con_message"" placeholder=""Message""></textarea>
                                    </div>
                                </div>
                                <div class=""col-12"">
                                    <div class=""form-group mb--0"">
                                        <button class=""btn-theme"" type=""submit"">Send Message</button>
                                    </div>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!--== End Contact Form ==-->
                    <!--== Message Notification ==-->
                    <div class=""form-message""></div>
                    <div class=""shape-group-style2"">
                        <div class=""shape-group-one""><img src=""assets/img/shape/13.webp"" width=""193"" height=""168"" alt=""Image-HasTech""></div>
                        <div class=""shape-group-two""><img src=""assets/img/shape/15.webp"" width=""221"" height=""113"" alt=""Image-HasTech""></div>
                        <div class=""shape-group-three""><img src=""assets/img/shape/16.webp"" width=""129"" height=""147"" alt=""Image-HasTech""></div>
                        <div class=""shape-group-four""><img src=""assets/img/shape/17.webp"" width=""493"" height=""340"" alt=""Image-HasTech""></div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3"">
                <div class=""contact-info-wrap"">
                    <div class=""contact-info"">
    ");
            WriteLiteral(@"                    <div class=""row"">
                            <div class=""col-lg-4 col-xl-12"">
                                <div class=""info-item"" data-aos=""fade-left"">
                                    <div class=""icon"">
                                        <img src=""assets/img/icons/c1.webp"" width=""69"" height=""65"" alt=""Image-HasTech"">
                                    </div>
                                    <div class=""info"">
                                        <h5 class=""title"">Address</h5>
                                        <p>Your address goes here. 123 Your Location</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4 col-xl-12"">
                                <div class=""info-item"" data-aos=""fade-left"" data-aos-delay=""60"">
                                    <div class=""icon"">
                                        <img src=""assets/img/icons/c2.");
            WriteLiteral(@"webp"" width=""65"" height=""65"" alt=""Image-HasTech"">
                                    </div>
                                    <div class=""info"">
                                        <h5 class=""title"">Phone No</h5>
                                        <p>
                                            <a href=""#"">+84 0987654321</a><br>
                                            <a href=""#"">+84 0987654321</a>
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4 col-xl-12"">
                                <div class=""info-item"" data-aos=""fade-left"" data-aos-delay=""120"">
                                    <div class=""icon"">
                                        <img src=""assets/img/icons/c3.webp"" width=""65"" height=""65"" alt=""Image-HasTech"">
                                    </div>
                                    <div class=""inf");
            WriteLiteral(@"o"">
                                        <h5 class=""title"">Email / Web</h5>
                                        <p>
                                            <a href=""#"">trung@gmail.com</a><br>
                                            <a href=""#"">trung@gmail.com</a>
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--== End Contact Area Wrapper ==-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
