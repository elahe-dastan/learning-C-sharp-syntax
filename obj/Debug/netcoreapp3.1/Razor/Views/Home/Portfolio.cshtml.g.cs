#pragma checksum "/home/raha/Desktop/MVCProject/Views/Home/Portfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3c8c44d777d06cab9ea3332d56570d47aa9d431"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Portfolio), @"mvc.1.0.view", @"/Views/Home/Portfolio.cshtml")]
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
#line 1 "/home/raha/Desktop/MVCProject/Views/_ViewImports.cshtml"
using MVCProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/raha/Desktop/MVCProject/Views/_ViewImports.cshtml"
using MVCProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c8c44d777d06cab9ea3332d56570d47aa9d431", @"/Views/Home/Portfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f87f51910e1016d2b81c8d4107669623c21b1e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Portfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!doctype html>
<html lang=""en"">

        <section class=""banner_area"">
            <div class=""box_1620"">
				<div class=""banner_inner d-flex align-items-center"">
					<div class=""container"">
						<div class=""banner_content text-center"">
							<h2>Portfolio</h2>
							<div class=""page_link"">
								<a href=""index.html"">Home</a>
								<a href=""portfolio.html"">Portfolio</a>
							</div>
						</div>
					</div>
				</div>
            </div>
        </section>
        <!--================End Home Banner Area =================-->
        
        <!--================Home Gallery Area =================-->
        <section class=""home_gallery_area p_120"">
        	<div class=""container"">
        		<div class=""main_title"">
        			<h2>Our Latest Featured Projects</h2>
        			<p>Who are in extremely love with eco friendly system.</p>
        		</div>
        		<div class=""isotope_fillter"">
        			<ul class=""gallery_filter list"">
						<li class=""active"" data-filter=""*""><a href=""#"">All</a></li>
				");
            WriteLiteral(@"		<li data-filter="".brand""><a href=""#"">Vector</a></li>
						<li data-filter="".manipul""><a href=""#"">Raster</a></li>
						<li data-filter="".creative""><a href=""#"">UI/UX</a></li>
						<li data-filter="".design""><a href=""#"">Printing</a></li>
					</ul>
        		</div>
        	</div>
        	<div class=""container"">
        		<div class=""gallery_f_inner row imageGallery1"">
        			<div class=""col-lg-4 col-md-4 col-sm-6 brand manipul design print"">
        				<div class=""h_gallery_item"">
        					<div class=""g_img_item"">
        						<img class=""img-fluid"" src=""img/gallery/project-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1624, "\"", 1630, 0);
            EndWriteAttribute();
            WriteLiteral(">\n        \t\t\t\t\t\t<a class=\"light\" href=\"img/gallery/project-1.jpg\"><img src=\"img/gallery/icon.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1728, "\"", 1734, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
        					</div>
        					<div class=""g_item_text"">
        						<h4>3D Helmet Design</h4>
        						<p>Client Project</p>
        					</div>
        				</div>
        			</div>
        			<div class=""col-lg-4 col-md-4 col-sm-6 brand manipul creative"">
        				<div class=""h_gallery_item"">
        					<div class=""g_img_item"">
        						<img class=""img-fluid"" src=""img/gallery/project-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2155, "\"", 2161, 0);
            EndWriteAttribute();
            WriteLiteral(">\n        \t\t\t\t\t\t<a class=\"light\" href=\"img/gallery/project-2.jpg\"><img src=\"img/gallery/icon.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2259, "\"", 2265, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
        					</div>
        					<div class=""g_item_text"">
        						<h4>2D Vinyl Design</h4>
        						<p>Client Project</p>
        					</div>
        				</div>
        			</div>
        			<div class=""col-lg-4 col-md-4 col-sm-6 manipul creative design print"">
        				<div class=""h_gallery_item"">
        					<div class=""g_img_item"">
        						<img class=""img-fluid"" src=""img/gallery/project-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2692, "\"", 2698, 0);
            EndWriteAttribute();
            WriteLiteral(">\n        \t\t\t\t\t\t<a class=\"light\" href=\"img/gallery/project-3.jpg\"><img src=\"img/gallery/icon.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2796, "\"", 2802, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
        					</div>
        					<div class=""g_item_text"">
        						<h4>Creative Poster Design</h4>
        						<p>Client Project</p>
        					</div>
        				</div>
        			</div>
        			<div class=""col-lg-4 col-md-4 col-sm-6 brand creative print"">
        				<div class=""h_gallery_item"">
        					<div class=""g_img_item"">
        						<img class=""img-fluid"" src=""img/gallery/project-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3227, "\"", 3233, 0);
            EndWriteAttribute();
            WriteLiteral(">\n        \t\t\t\t\t\t<a class=\"light\" href=\"img/gallery/project-4.jpg\"><img src=\"img/gallery/icon.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3331, "\"", 3337, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
        					</div>
        					<div class=""g_item_text"">
        						<h4>Embosed Logo Design</h4>
        						<p>Client Project</p>
        					</div>
        				</div>
        			</div>
        			<div class=""col-lg-4 col-md-4 col-sm-6 brand manipul design"">
        				<div class=""h_gallery_item"">
        					<div class=""g_img_item"">
        						<img class=""img-fluid"" src=""img/gallery/project-5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3759, "\"", 3765, 0);
            EndWriteAttribute();
            WriteLiteral(">\n        \t\t\t\t\t\t<a class=\"light\" href=\"img/gallery/project-5.jpg\"><img src=\"img/gallery/icon.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3863, "\"", 3869, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
        					</div>
        					<div class=""g_item_text"">
        						<h4>3D Disposable Bottle</h4>
        						<p>Client Project</p>
        					</div>
        				</div>
        			</div>
        			<div class=""col-lg-4 col-md-4 col-sm-6 brand creative"">
        				<div class=""h_gallery_item"">
        					<div class=""g_img_item"">
        						<img class=""img-fluid"" src=""img/gallery/project-6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4286, "\"", 4292, 0);
            EndWriteAttribute();
            WriteLiteral(">\n        \t\t\t\t\t\t<a class=\"light\" href=\"img/gallery/project-6.jpg\"><img src=\"img/gallery/icon.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4390, "\"", 4396, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
        					</div>
        					<div class=""g_item_text"">
        						<h4>3D Logo Design</h4>
        						<p>Client Project</p>
        					</div>
        				</div>
        			</div>
        		</div>
        		<div class=""more_btn"">
        			<a class=""main_btn"" href=""#"">Load More Items</a>
        		</div>
        	</div>
        </section>
        <!--================End Home Gallery Area =================-->
</html>");
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
