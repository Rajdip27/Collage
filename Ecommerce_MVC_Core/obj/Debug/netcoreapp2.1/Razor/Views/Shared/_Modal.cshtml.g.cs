#pragma checksum "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\Shared\_Modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e859468b26c87071b58e3ae62b920b55ce245a81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Modal), @"mvc.1.0.view", @"/Views/Shared/_Modal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Modal.cshtml", typeof(AspNetCore.Views_Shared__Modal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e859468b26c87071b58e3ae62b920b55ce245a81", @"/Views/Shared/_Modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71cfa9c3ae2f1e0493d4ca25e3a3394ef37b5862", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Modal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerce_MVC_Core.BootstrapModal.BootstrapModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 24, true);
            WriteLiteral("\n<div aria-hidden=\"true\"");
            EndContext();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 80, "\"", 118, 1);
#line 3 "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\Shared\_Modal.cshtml"
WriteAttributeValue("", 98, Model.AreaLabeledId, 98, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(119, 28, true);
            WriteLiteral(" role=\"dialog\" tabindex=\"-1\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 147, "\"", 161, 1);
#line 3 "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\Shared\_Modal.cshtml"
WriteAttributeValue("", 152, Model.ID, 152, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(162, 29, true);
            WriteLiteral(" class=\"modal fade\">\n    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 191, "\"", 233, 2);
            WriteAttributeValue("", 199, "modal-dialog", 199, 12, true);
#line 4 "C:\Users\Santnu\Desktop\Ecommerce_MVC_Core\Ecommerce_MVC_Core\Views\Shared\_Modal.cshtml"
WriteAttributeValue(" ", 211, Model.ModalSizeClass, 212, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(234, 71, true);
            WriteLiteral(">\n        <div class=\"modal-content\">\n        </div>\n    </div>\n</div> ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce_MVC_Core.BootstrapModal.BootstrapModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
