#pragma checksum "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\views\Views\Movies\Random.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3d6bf09e4c388f8c769d2d3d0fc8262da4c7400"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Random), @"mvc.1.0.view", @"/Views/Movies/Random.cshtml")]
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
#line 1 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\views\Views\_ViewImports.cshtml"
using views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\views\Views\_ViewImports.cshtml"
using views.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3d6bf09e4c388f8c769d2d3d0fc8262da4c7400", @"/Views/Movies/Random.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"194605000379f0e48e05f89c49d7b9d76283cce3", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Random : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<views.ViewModel.Ran>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\views\Views\Movies\Random.cshtml"
  
    ViewBag.Tittle = "Random";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 5 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\views\Views\Movies\Random.cshtml"
Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h2>");
#nullable restore
#line 7 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\views\Views\Movies\Random.cshtml"
Write(((Movie)ViewData["Movies"]).name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<views.ViewModel.Ran> Html { get; private set; }
    }
}
#pragma warning restore 1591