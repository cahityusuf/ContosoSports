#pragma checksum "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28eb10627cb0e2727812003d4972725771e64744"
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
#line 1 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Admin\Views\_ViewImports.cshtml"
using Contoso.Apps.SportsLeague.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Admin\Views\_ViewImports.cshtml"
using Contoso.Apps.SportsLeague.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28eb10627cb0e2727812003d4972725771e64744", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6f804e02bbf57145cc2797d693835a35dc15cd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contoso.Apps.SportsLeague.Admin.Models.HomeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Admin\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Admin Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12""><br /></div>
</div>

<div class=""jumbotron"">
    <h2>Contoso Sports League Admin</h2>
    <p class=""lead"">Below is a list of orders, sorted by reverse order date. You may click on an order to see its details and to obtain the generated PDF receipt.</p>
    <p><a");
            BeginWriteAttribute("href", " href=\"", 415, "\"", 450, 1);
#nullable restore
#line 13 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 422, Url.Action("About", "Home"), 422, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn red-btn btn-lg"">Learn more &raquo;</a></p>
</div>

<h1>Completed Orders</h1>

<table class=""table table-striped table-hover table-condensed"">
    <thead>
        <tr class=""active"">
            <th>Order Details</th>
            <th>Order Date</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Total</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Admin\Views\Home\Index.cshtml"
         foreach(var item in Model.Orders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 32 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Admin\Views\Home\Index.cshtml"
                Write(Html.ActionLink("Details", "Details", "Home", new { Id = item.OrderId }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Admin\Views\Home\Index.cshtml"
                Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Admin\Views\Home\Index.cshtml"
                Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Admin\Views\Home\Index.cshtml"
                Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Admin\Views\Home\Index.cshtml"
                Write(item.Total.ToString("{0:c}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Admin\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contoso.Apps.SportsLeague.Admin.Models.HomeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591