#pragma checksum "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\EF04\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eaa05f58bcde4b5171ad3c998f5bf483277767d"
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
#line 1 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\EF04\Views\_ViewImports.cshtml"
using EF04;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\EF04\Views\_ViewImports.cshtml"
using EF04.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eaa05f58bcde4b5171ad3c998f5bf483277767d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8474473b37ffb86f6fea0f1329fa78529463d8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\EF04\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<input id=""userName""/>
<button id=""add""> ADD USER</button>
<div id=""div""></div>

<script>
    let userName = document.getElementById(""userName"");
    let add = document.getElementById(""add"");
    let div = document.getElementById(""div"");

    var data = {
        ""userName"" : userName.value,
    }

    add.addEventListener(""click"", function () {
       
        fetch(""https://localhost:44321/api/users"", {
            method: ""post"",
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(data),
        }).then(response => response.json())
            .then(data => {
                console.log('Success:', data)
            })
            .catch((error) => {
               
            })
      
    })

    fetch(""https://localhost:44321/api/users"").then(function (res) {
        res.json().then(function (data) {
            for (let i = 0; data.length > i; i++) {
                let li = document.createElemen");
            WriteLiteral("t(\"li\");\r\n                li.innerHTML = data[i].userName;\r\n                div.append(li);\r\n            }\r\n        })\r\n    })\r\n\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
