#pragma checksum "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "629d49b08c8bcdd3fe29841e464a85dbbda916a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Index), @"mvc.1.0.view", @"/Views/Store/Index.cshtml")]
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
#line 1 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\_ViewImports.cshtml"
using Contoso.Apps.SportsLeague.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\_ViewImports.cshtml"
using Contoso.Apps.SportsLeague.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"629d49b08c8bcdd3fe29841e464a85dbbda916a0", @"/Views/Store/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26569d82efc307699895556049274a32bd1308f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contoso.Apps.SportsLeague.Web.Models.StoreIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("HeaderOverlay", async() => {
                WriteLiteral("\n    <div class=\"button-wrapper\">\n        <div class=\"container\">\n            <div class=\"row\">\n                <a href=\"#\" class=\"btn-content\">Contoso Store</a>\n            </div>\n        </div>\n    </div>\n");
            }
            );
            WriteLiteral("\n<!-- start of gallery -->\n<section class=\"gallery-page-wrapper events\">\n    <div class=\"container\">\n        <ul class=\"menu-wrapper\" id=\"menu\">\n            <li><a href=\"#menu\" data-filter=\"*\" class=\"headline-lato selected\">select all</a></li>\n");
#nullable restore
#line 22 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
             foreach (var category in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a href=\"#menu\" data-filter=\".");
#nullable restore
#line 24 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
                                             Write(category.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"headline-lato\">");
#nullable restore
#line 24 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
                                                                                         Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 25 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n        <div class=\"row\">\n            <div class=\"wrapper isp-wrap\">\n                <div class=\"clearfix\" id=\"list-item\">\n");
#nullable restore
#line 30 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
                     foreach (var product in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1031, "\"", 1065, 2);
            WriteAttributeValue("", 1039, "figure", 1039, 6, true);
#nullable restore
#line 32 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
WriteAttributeValue(" ", 1045, product.CategoryID, 1046, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <div class=\"item clearfix\">\n                                <a class=\"item-img\"");
            BeginWriteAttribute("href", " href=\"", 1175, "\"", 1245, 1);
#nullable restore
#line 34 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
WriteAttributeValue("", 1182, Url.Action("Details", "Store", new { id = product.ProductID }), 1182, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1288, "\"", 1346, 2);
#nullable restore
#line 35 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
WriteAttributeValue("", 1294, Url.Content("~/Images/Products/"), 1294, 34, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
WriteAttributeValue("", 1328, product.ImagePath, 1328, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1347, "\"", 1373, 1);
#nullable restore
#line 35 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
WriteAttributeValue("", 1353, product.ProductName, 1353, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"center-block\">\n                                </a>\n                                <div class=\"item-content\">\n                                    <h4 class=\"headline-lato\">");
#nullable restore
#line 38 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
                                                         Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                    <div class=""item-footer clearfix"">
                                        <div class=""footer-content"">
                                            <div class=""wrap clearfix"">
                                                <span class=""text-primary"" style=""font-size:1.5em"">");
#nullable restore
#line 42 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
                                                                                              Write(String.Format("{0:c}", product.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                            </div>\n                                        </div>\n                                        <div class=\"footer-button\">\n                                            <a class=\"btn trans-btn\"");
            BeginWriteAttribute("href", " href=\"", 2176, "\"", 2254, 1);
#nullable restore
#line 46 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
WriteAttributeValue("", 2183, Url.Action("AddToCart", "Cart", new { productId = product.ProductID }), 2183, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add to cart</a>\n                                        </div>\n                                    </div>\n                                </div>\n                            </div>\n                        </div>\n");
#nullable restore
#line 52 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Store\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contoso.Apps.SportsLeague.Web.Models.StoreIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
