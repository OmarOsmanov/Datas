#pragma checksum "C:\Users\Hp-pavilion\Desktop\New folder\WebApplication35\WebApplication35\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3686c2036c2f3398aa54128835441b8e83b984f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\Hp-pavilion\Desktop\New folder\WebApplication35\WebApplication35\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp-pavilion\Desktop\New folder\WebApplication35\WebApplication35\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3686c2036c2f3398aa54128835441b8e83b984f2", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OurTeams>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hp-pavilion\Desktop\New folder\WebApplication35\WebApplication35\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page Content -->
<div class=""page-heading about-heading header-text"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""text-content"">
                    <h4>about us</h4>
                    <h2>our company</h2>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""best-features about-features"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""section-heading"">
                    <h2>Our Background</h2>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""right-image"">
                    <img src=""assets/images/feature-image.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 859, "\"", 865, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""left-content"">
                    <h4>Who we are &amp; What we do?</h4>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sed voluptate nihil eum consectetur similique? Consectetur, quod, incidunt, harum nisi dolores delectus reprehenderit voluptatem perferendis dicta dolorem non blanditiis ex fugiat. Lorem ipsum dolor sit amet, consectetur adipisicing elit.<br><br>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Et, consequuntur, modi mollitia corporis ipsa voluptate corrupti eum ratione ex ea praesentium quibusdam? Aut, in eum facere corrupti necessitatibus perspiciatis quis.</p>
                    <ul class=""social-icons"">
                        <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-linkedin""></i></");
            WriteLiteral(@"a></li>
                        <li><a href=""#""><i class=""fa fa-behance""></i></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""team-members"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""section-heading"">
                    <h2>Our Team Members</h2>
                </div>
            </div>
");
#nullable restore
#line 59 "C:\Users\Hp-pavilion\Desktop\New folder\WebApplication35\WebApplication35\Views\About\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <div class=\"team-member\">\r\n                <div class=\"thumb-container\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2548, "\"", 2579, 2);
            WriteAttributeValue("", 2554, "assets/images/", 2554, 14, true);
#nullable restore
#line 64 "C:\Users\Hp-pavilion\Desktop\New folder\WebApplication35\WebApplication35\Views\About\Index.cshtml"
WriteAttributeValue("", 2568, item.Image, 2568, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2580, "\"", 2586, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""hover-effect"">
                        <div class=""hover-content"">
                            <ul class=""social-icons"">
                                <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-linkedin""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-behance""></i></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""down-content"">
                    <h4>");
#nullable restore
#line 77 "C:\Users\Hp-pavilion\Desktop\New folder\WebApplication35\WebApplication35\Views\About\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 77 "C:\Users\Hp-pavilion\Desktop\New folder\WebApplication35\WebApplication35\Views\About\Index.cshtml"
                              Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <span>");
#nullable restore
#line 78 "C:\Users\Hp-pavilion\Desktop\New folder\WebApplication35\WebApplication35\Views\About\Index.cshtml"
                     Write(item.Position.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <p>");
#nullable restore
#line 79 "C:\Users\Hp-pavilion\Desktop\New folder\WebApplication35\WebApplication35\Views\About\Index.cshtml"
                  Write(item.Context);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 83 "C:\Users\Hp-pavilion\Desktop\New folder\WebApplication35\WebApplication35\Views\About\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            
            
        </div>
    </div>
</div>


<div class=""services"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""service-item"">
                    <div class=""icon"">
                        <i class=""fa fa-gear""></i>
                    </div>
                    <div class=""down-content"">
                        <h4>Product Management</h4>
                        <p>Lorem ipsum dolor sit amet, consectetur an adipisicing elit. Itaque, corporis nulla at quia quaerat.</p>
                        <a href=""#"" class=""filled-button"">Read More</a>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""service-item"">
                    <div class=""icon"">
                        <i class=""fa fa-gear""></i>
                    </div>
                    <div class=""down-content"">
                        <h4>Customer Relations</h");
            WriteLiteral(@"4>
                        <p>Lorem ipsum dolor sit amet, consectetur an adipisicing elit. Itaque, corporis nulla at quia quaerat.</p>
                        <a href=""#"" class=""filled-button"">Details</a>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""service-item"">
                    <div class=""icon"">
                        <i class=""fa fa-gear""></i>
                    </div>
                    <div class=""down-content"">
                        <h4>Global Collection</h4>
                        <p>Lorem ipsum dolor sit amet, consectetur an adipisicing elit. Itaque, corporis nulla at quia quaerat.</p>
                        <a href=""#"" class=""filled-button"">Read More</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""happy-clients"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
    ");
            WriteLiteral(@"            <div class=""section-heading"">
                    <h2>Happy Partners</h2>
                </div>
            </div>
            <div class=""col-md-12"">
                <div class=""owl-clients owl-carousel"">
                    <div class=""client-item"">
                        <img src=""assets/images/client-01.png"" alt=""1"">
                    </div>

                    <div class=""client-item"">
                        <img src=""assets/images/client-01.png"" alt=""2"">
                    </div>

                    <div class=""client-item"">
                        <img src=""assets/images/client-01.png"" alt=""3"">
                    </div>

                    <div class=""client-item"">
                        <img src=""assets/images/client-01.png"" alt=""4"">
                    </div>

                    <div class=""client-item"">
                        <img src=""assets/images/client-01.png"" alt=""5"">
                    </div>

                    <div class=""client-item"">
  ");
            WriteLiteral("                      <img src=\"assets/images/client-01.png\" alt=\"6\">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OurTeams>> Html { get; private set; }
    }
}
#pragma warning restore 1591
