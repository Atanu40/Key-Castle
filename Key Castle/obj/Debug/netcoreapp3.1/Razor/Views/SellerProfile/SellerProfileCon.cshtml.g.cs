#pragma checksum "E:\SD 3.2\Key Castle\Key Castle\Views\SellerProfile\SellerProfileCon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fed54174cbe4b2ca75a66fd736df3183c5b6984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SellerProfile_SellerProfileCon), @"mvc.1.0.view", @"/Views/SellerProfile/SellerProfileCon.cshtml")]
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
#line 1 "E:\SD 3.2\Key Castle\Key Castle\Views\_ViewImports.cshtml"
using Key_Castle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SD 3.2\Key Castle\Key Castle\Views\_ViewImports.cshtml"
using Key_Castle.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fed54174cbe4b2ca75a66fd736df3183c5b6984", @"/Views/SellerProfile/SellerProfileCon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"196a6b7afd33ae21edc006ced3ea7a5f4003c72f", @"/Views/_ViewImports.cshtml")]
    public class Views_SellerProfile_SellerProfileCon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Key_Castle.Models.Seller_Profile>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container p-3\">\r\n    <div class=\"row p-4\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-primary\">Seller\'s List</h2>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 14 "E:\SD 3.2\Key Castle\Key Castle\Views\SellerProfile\SellerProfileCon.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered table-striped"" style=""width:100%"">
        <thead>
            <tr>
                <th>Seller Id</th>
                <th>Shop Name</th>
                <th>Item Sold</th>
                <th>Photo</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "E:\SD 3.2\Key Castle\Key Castle\Views\SellerProfile\SellerProfileCon.cshtml"
             foreach (var obj in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td width=\"50%\">");
#nullable restore
#line 29 "E:\SD 3.2\Key Castle\Key Castle\Views\SellerProfile\SellerProfileCon.cshtml"
                           Write(obj.Seller_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td width=\"30%\">");
#nullable restore
#line 30 "E:\SD 3.2\Key Castle\Key Castle\Views\SellerProfile\SellerProfileCon.cshtml"
                           Write(obj.ShopName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td width=\"30%\">");
#nullable restore
#line 31 "E:\SD 3.2\Key Castle\Key Castle\Views\SellerProfile\SellerProfileCon.cshtml"
                           Write(obj.Item_sold);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td width=\"30%\">");
#nullable restore
#line 32 "E:\SD 3.2\Key Castle\Key Castle\Views\SellerProfile\SellerProfileCon.cshtml"
                           Write(obj.Seller_photo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "E:\SD 3.2\Key Castle\Key Castle\Views\SellerProfile\SellerProfileCon.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 37 "E:\SD 3.2\Key Castle\Key Castle\Views\SellerProfile\SellerProfileCon.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Nothing</p>\r\n");
#nullable restore
#line 41 "E:\SD 3.2\Key Castle\Key Castle\Views\SellerProfile\SellerProfileCon.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Key_Castle.Models.Seller_Profile>> Html { get; private set; }
    }
}
#pragma warning restore 1591
