#pragma checksum "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\Shared\_HeaderMainMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a859481f3061a65a07e9060957e60f441823658"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderMainMenu), @"mvc.1.0.view", @"/Views/Shared/_HeaderMainMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_HeaderMainMenu.cshtml", typeof(AspNetCore.Views_Shared__HeaderMainMenu))]
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
#line 1 "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core;

#line default
#line hidden
#line 2 "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.Models;

#line default
#line hidden
#line 4 "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using System.Collections;

#line default
#line hidden
#line 5 "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.BootstrapModal;

#line default
#line hidden
#line 6 "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.Code;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a859481f3061a65a07e9060957e60f441823658", @"/Views/Shared/_HeaderMainMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71cfa9c3ae2f1e0493d4ca25e3a3394ef37b5862", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HeaderMainMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ecommerce_MVC_Core.ViewModel.CategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(68, 6, true);
            WriteLiteral("\n    \n");
            EndContext();
#line 5 "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\Shared\_HeaderMainMenu.cshtml"
 foreach (var item in Model)
{
        
           

#line default
#line hidden
            BeginContext(126, 38, true);
            WriteLiteral("    <div class=\"col-md-4\">\n        <b>");
            EndContext();
            BeginContext(165, 9, false);
#line 10 "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\Shared\_HeaderMainMenu.cshtml"
      Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(174, 16, true);
            WriteLiteral("</b>\n        <p>");
            EndContext();
            BeginContext(191, 16, false);
#line 11 "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\Shared\_HeaderMainMenu.cshtml"
      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(207, 56, true);
            WriteLiteral("</p>\n\n        <ol>\n           \n        </ol>\n    </div>\n");
            EndContext();
#line 17 "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\Shared\_HeaderMainMenu.cshtml"

          
        
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ecommerce_MVC_Core.ViewModel.CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
