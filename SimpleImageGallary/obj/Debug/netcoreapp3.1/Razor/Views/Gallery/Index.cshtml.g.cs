#pragma checksum "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\SimpleImageGallary\Views\Gallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de25e5c1b4a1874df8ddd3fa5c8b6f0f9c09195e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Index), @"mvc.1.0.view", @"/Views/Gallery/Index.cshtml")]
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
#line 1 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\SimpleImageGallary\Views\_ViewImports.cshtml"
using SimpleImageGallary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\SimpleImageGallary\Views\_ViewImports.cshtml"
using SimpleImageGallary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de25e5c1b4a1874df8ddd3fa5c8b6f0f9c09195e", @"/Views/Gallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af5b825165522f8b057b75ef6b5de14f75418488", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleImageGallary.Models.GalleryIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n    <div class=\"gallery-content\">\r\n");
#nullable restore
#line 5 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\SimpleImageGallary\Views\Gallery\Index.cshtml"
         foreach (var image in Model.Images)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"gallery-image\"");
            BeginWriteAttribute("style", " style=\"", 223, "\"", 263, 3);
            WriteAttributeValue("", 231, "background-image:url(", 231, 21, true);
#nullable restore
#line 7 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\SimpleImageGallary\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 252, image.url, 252, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 262, ")", 262, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <span>");
#nullable restore
#line 8 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\SimpleImageGallary\Views\Gallery\Index.cshtml"
             Write(image.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <ul>\r\n");
#nullable restore
#line 10 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\SimpleImageGallary\Views\Gallery\Index.cshtml"
                 foreach(var tag in image.Tags)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                    ");
#nullable restore
#line 13 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\SimpleImageGallary\Views\Gallery\Index.cshtml"
               Write(tag.Discription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 15 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\SimpleImageGallary\Views\Gallery\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 17 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\SimpleImageGallary\Views\Gallery\Index.cshtml"
          
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleImageGallary.Models.GalleryIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591