#pragma checksum "F:\lab6\lab6\Views\Home\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b0d82471c833f8de27c086560d78e9a4f0cd3f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_All), @"mvc.1.0.view", @"/Views/Home/All.cshtml")]
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
#line 1 "F:\lab6\lab6\Views\_ViewImports.cshtml"
using lab6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\lab6\lab6\Views\_ViewImports.cshtml"
using lab6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b0d82471c833f8de27c086560d78e9a4f0cd3f0", @"/Views/Home/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"636dd2a57aedcb9489861fc0ee664ce480df50fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Car List</h3>\r\n\r\n");
#nullable restore
#line 5 "F:\lab6\lab6\Views\Home\All.cshtml"
 foreach (var c in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 8 "F:\lab6\lab6\Views\Home\All.cshtml"
   Write(c.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 8 "F:\lab6\lab6\Views\Home\All.cshtml"
             Write(c.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 10 "F:\lab6\lab6\Views\Home\All.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
