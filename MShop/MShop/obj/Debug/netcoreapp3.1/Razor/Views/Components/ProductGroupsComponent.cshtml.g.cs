#pragma checksum "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Components\ProductGroupsComponent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20c0a134fc7f3aec7cca085ae5c262c1365c8397"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_ProductGroupsComponent), @"mvc.1.0.view", @"/Views/Components/ProductGroupsComponent.cshtml")]
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
#line 1 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\_ViewImports.cshtml"
using MShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\_ViewImports.cshtml"
using MShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c0a134fc7f3aec7cca085ae5c262c1365c8397", @"/Views/Components/ProductGroupsComponent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281090be53ec65c2a27618480cd01fea8fa82be8", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_ProductGroupsComponent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShowGroupViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"list-group\">\r\n\r\n");
#nullable restore
#line 5 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Components\ProductGroupsComponent.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 212, "\"", 250, 4);
            WriteAttributeValue("", 219, "/Group/", 219, 7, true);
#nullable restore
#line 8 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Components\ProductGroupsComponent.cshtml"
WriteAttributeValue("", 226, item.GroupId, 226, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 239, "/", 239, 1, true);
#nullable restore
#line 8 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Components\ProductGroupsComponent.cshtml"
WriteAttributeValue("", 240, item.Name, 240, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Components\ProductGroupsComponent.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            <span class=\"badge badge-primary badge-pill\">");
#nullable restore
#line 9 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Components\ProductGroupsComponent.cshtml"
                                                    Write(item.ProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </li>\r\n");
#nullable restore
#line 11 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Components\ProductGroupsComponent.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShowGroupViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
