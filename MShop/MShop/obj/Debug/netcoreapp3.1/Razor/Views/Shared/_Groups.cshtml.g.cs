#pragma checksum "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Shared\_Groups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8484d2f391b96efae098342fdcdc2bb5c316445f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Groups), @"mvc.1.0.view", @"/Views/Shared/_Groups.cshtml")]
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
#nullable restore
#line 1 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Shared\_Groups.cshtml"
using MShop.Data.Repositories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8484d2f391b96efae098342fdcdc2bb5c316445f", @"/Views/Shared/_Groups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281090be53ec65c2a27618480cd01fea8fa82be8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Groups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<li class=""nav-item dropdown show"">
    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true"">
        گروه ها
    </a>
    <div class=""dropdown-menu show"" aria-labelledby=""navbarDropdown"">

");
#nullable restore
#line 11 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Shared\_Groups.cshtml"
         foreach (var item in _GroupRepository.GetAllCategories())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 482, "\"", 515, 4);
            WriteAttributeValue("", 489, "/Group/", 489, 7, true);
#nullable restore
#line 13 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Shared\_Groups.cshtml"
WriteAttributeValue("", 496, item.Id, 496, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 504, "/", 504, 1, true);
#nullable restore
#line 13 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Shared\_Groups.cshtml"
WriteAttributeValue("", 505, item.Name, 505, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Shared\_Groups.cshtml"
                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 14 "E:\Develpoer\Project\MShop\MShop\MShop\MShop\Views\Shared\_Groups.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</li>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IGroupRepository _GroupRepository { get; private set; }
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
