#pragma checksum "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\BuyerProfile\BuyerProfileCon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd05ba1ffbb985c96db4eb3b9e330975d8e39370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BuyerProfile_BuyerProfileCon), @"mvc.1.0.view", @"/Views/BuyerProfile/BuyerProfileCon.cshtml")]
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
#line 1 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\_ViewImports.cshtml"
using Key_Castle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\_ViewImports.cshtml"
using Key_Castle_Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd05ba1ffbb985c96db4eb3b9e330975d8e39370", @"/Views/BuyerProfile/BuyerProfileCon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6838a7015289068391c312b1a985fe5b0e51cd58", @"/Views/_ViewImports.cshtml")]
    public class Views_BuyerProfile_BuyerProfileCon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Key_Castle_Models.Buyer_Profile>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"container p-3\">\n    <div class=\"row p-4\">\n        <div class=\"col-6\">\n            <h2 class=\"text-primary\">Buyer\'s List</h2>\n        </div>\n    </div>\n</div>\n\n<br />\n<br />\n\n");
#nullable restore
#line 14 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\BuyerProfile\BuyerProfileCon.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered table-striped"" style=""width:100%"">
        <thead>
            <tr>
                <th>Buyer Id</th>
                <th>Full Name</th>
                <th>Item Purchase</th>
                <th>Photo</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\BuyerProfile\BuyerProfileCon.cshtml"
             foreach (var obj in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td width=\"50%\">");
#nullable restore
#line 29 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\BuyerProfile\BuyerProfileCon.cshtml"
                           Write(obj.Buyer_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td width=\"30%\">");
#nullable restore
#line 30 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\BuyerProfile\BuyerProfileCon.cshtml"
                           Write(obj.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td width=\"50%\">");
#nullable restore
#line 31 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\BuyerProfile\BuyerProfileCon.cshtml"
                           Write(obj.Item_purchase);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td width=\"30%\">");
#nullable restore
#line 32 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\BuyerProfile\BuyerProfileCon.cshtml"
                           Write(obj.Buyer_photo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 34 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\BuyerProfile\BuyerProfileCon.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 37 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\BuyerProfile\BuyerProfileCon.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Nothing</p>\n");
#nullable restore
#line 41 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\BuyerProfile\BuyerProfileCon.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Key_Castle_Models.Buyer_Profile>> Html { get; private set; }
    }
}
#pragma warning restore 1591