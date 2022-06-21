#pragma checksum "D:\BadNewsWebApp\BadNewsWebApp\BadNewsWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "848f046bdbb8c3915286c4e39325fbb7f30a056d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\BadNewsWebApp\BadNewsWebApp\BadNewsWebApp\Views\_ViewImports.cshtml"
using BadNewsWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BadNewsWebApp\BadNewsWebApp\BadNewsWebApp\Views\_ViewImports.cshtml"
using BadNewsWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"848f046bdbb8c3915286c4e39325fbb7f30a056d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f05cabbe0f99e6b397abd1cb4a4d4ff3640730b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BadNews.Models.Post>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\BadNewsWebApp\BadNewsWebApp\BadNewsWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "848f046bdbb8c3915286c4e39325fbb7f30a056d4149", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 186, "\"", 196, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <!-- The above 4 meta tags *must* come first in the head; any other head content must come *after* these tags -->

    <!-- Title  -->
    <title>Bad News | Home</title>

    <!-- Favicon  -->
    <link rel=""icon"" href=""img/core-images/favicon.ico"">

    <!-- Core Style CSS -->
    <link rel=""stylesheet"" href=""css/core-style.css"">
    <link rel=""stylesheet"" href=""style.css"">

    <!-- Responsive CSS -->
    <link href=""css/responsive.css"" rel=""stylesheet"">

");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "848f046bdbb8c3915286c4e39325fbb7f30a056d5997", async() => {
                WriteLiteral(@"
    <!-- Welcome Blog Slide Area Start -->
    <section class=""welcome-blog-post-slide owl-carousel"">
        <!-- Single Blog Post -->
        <div class=""single-blog-post-slide bg-img background-overlay-5"" style=""background-image: url(images/bg-img/2.jpg);"">
            <!-- Single Blog Post Content -->
            <div class=""single-blog-post-content"">
                <div class=""tags"">
                    <a href=""#"">live</a>
                </div>
                <h3><a href=""#"" class=""font-pt"">The latest news live</a></h3>
                <div class=""date"">
                    <a href=""#"">March 29, 2018</a>
                </div>
            </div>
        </div>
    </section>
    <!-- Welcome Blog Slide Area End -->

    <!-- Main Content Area Start -->
    <section class=""main-content-wrapper section_padding_100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 col-lg-9"">
                    <!-- Gazette Welcome Post -->
     ");
                WriteLiteral(@"               <div class=""gazette-welcome-post"">
                        <!-- Post Tag -->
                        <div class=""gazette-post-tag"">
                            <a href=""#"">Model.CategoryId</a>
                        </div>
                        <h2 class=""font-pt"">Model.Title</h2>
                        <p class=""gazette-post-date"">Model.CreatedAt</p>
                        <!-- Post Thumbnail -->
                        <div class=""blog-post-thumbnail my-5"">
                            <img src=""images/blog-img/Model.ImageCover"" alt=""post-thumb"">
                        </div>
                        <!-- Post Excerpt -->
                        <p>Model.Introduction</p>
                        <!-- Reading More -->
                        <div class=""post-continue-reading-share d-sm-flex align-items-center justify-content-between mt-30"">
                            <div class=""post-continue-btn"">
                                <a href=""#"" class=""font-pt"">Continue Reading");
                WriteLiteral(@" <i class=""fa fa-chevron-right"" aria-hidden=""true""></i></a>
                            </div>
                            <div class=""post-share-btn-group"">
                                <a href=""#""><i class=""fa fa-pinterest"" aria-hidden=""true""></i></a>
                                <a href=""#""><i class=""fa fa-linkedin"" aria-hidden=""true""></i></a>
                                <a href=""#""><i class=""fa fa-facebook"" aria-hidden=""true""></i></a>
                                <a href=""#""><i class=""fa fa-twitter"" aria-hidden=""true""></i></a>
                            </div>
                        </div>
                    </div>

                    <div class=""gazette-todays-post section_padding_100_50"">
                        <div class=""gazette-heading"">
                            <h4>today’s most popular</h4>
                        </div>
                        <!-- Single Today Post -->
                        <div class=""gazette-single-todays-post d-md-flex align-items-start mb");
                WriteLiteral("-50\">\r\n                            <div class=\"todays-post-thumb\">\r\n                                <img src=\"images/blog-img/2.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 4053, "\"", 4059, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                            <div class=""todays-post-content"">
                                <!-- Post Tag -->
                                <div class=""gazette-post-tag"">
                                    <a href=""#"">News</a>
                                </div>
                                <h3><a href=""#"" class=""font-pt mb-2"">Model.Title</a></h3>
                                <span class=""gazette-post-date mb-2"">Model.CreateAt</span>
                                <a href=""#"" class=""post-total-comments"">Count Comments</a>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse ultrices egestas nunc, quis venenatis orci tincidunt id. Fusce commodo blandit eleifend. Nullam viverra tincidunt dolor, at pulvinar dui. Nullam at risus ut ipsum viverra posuere.</p>
                            </div>
                        </div>
                    </div>
                </div>

                <div cl");
                WriteLiteral(@"ass=""col-12 col-lg-3 col-md-6"">
                    <div class=""sidebar-area"">
                        <!-- Breaking News Widget -->
                        <div class=""breaking-news-widget"">
                            <div class=""widget-title"">
                                <h5>breaking news</h5>
                            </div>
                            <!-- Single Breaking News Widget -->
                            <div class=""single-breaking-news-widget"">
                                <img src=""images/blog-img/bn-1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 5632, "\"", 5638, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <div class=""breakingnews-title"">
                                    <p>breaking news</p>
                                </div>
                                <div class=""breaking-news-heading gradient-background-overlay"">
                                    <h5 class=""font-pt"">China leads new global skyscraper record</h5>
                                </div>
                            </div>
                        </div>

                        <!-- Don't Miss Widget -->
                        <div class=""donnot-miss-widget"">
                            <div class=""widget-title"">
                                <h5>Don't miss</h5>
                            </div>
                            <!-- Single Don't Miss Post -->
                            <div class=""single-dont-miss-post d-flex mb-30"">
                                <div class=""dont-miss-post-thumb"">
                                    <img src=""images/blog-img/dm-1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 6649, "\"", 6655, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""dont-miss-post-content"">
                                    <a href=""#"" class=""font-pt"">EU council reunites</a>
                                    <span>Nov 29, 2017</span>
                                </div>
                            </div>
                        </div>
                        <!-- Subscribe Widget -->
                        <div class=""subscribe-widget"">
                            <div class=""widget-title"">
                                <h5>subscribe</h5>
                            </div>
                            <div class=""subscribe-form"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "848f046bdbb8c3915286c4e39325fbb7f30a056d13500", async() => {
                    WriteLiteral("\r\n                                    <input type=\"email\" name=\"email\" id=\"subs_email\" placeholder=\"Your Email\">\r\n                                    <button type=\"submit\">subscribe</button>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Main Content Area End -->
    </section>

    <!-- Video Posts Area Start -->
    <section class=""gazatte-video-post-area section_padding_100_70 bg-gray"">
        <div class=""container"">
            <div class=""row"">
                <!-- Single Video Post Start -->
                <div class=""col-12 col-md-3"">
                    <div class=""single-video-post"">
                        <div class=""video-post-thumb"">
                            <img src=""images/blog-img/4.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 8279, "\"", 8285, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <a href=""https://youtu.be/dIyXl9ZHEgg"" class=""videobtn""><i class=""fa fa-play"" aria-hidden=""true""></i></a>
                        </div>
                        <h5><a href=""#"">Show suspended by PBS amid misconduct allegations</a></h5>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- Video Posts Area End -->

    <!-- Editorial Area End -->
    <!-- jQuery (Necessary for All JavaScript Plugins) -->
    <script src=""js/jquery/jquery-2.2.4.min.js""></script>
    <!-- Popper js -->
    <script src=""js/popper.min.js""></script>
    <!-- Bootstrap js -->
    <script src=""js/bootstrap.min.js""></script>
    <!-- Plugins js -->
    <script src=""js/plugins.js""></script>
    <!-- Active js -->
    <script src=""js/active.js""></script>

");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BadNews.Models.Post>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591