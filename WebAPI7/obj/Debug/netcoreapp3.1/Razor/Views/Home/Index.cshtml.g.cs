#pragma checksum "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\WebAPI7\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57b435c36999f55b767655cd9f20cf2c6692d356"
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
#line 1 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\WebAPI7\Views\_ViewImports.cshtml"
using WebAPI7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\WebAPI7\Views\_ViewImports.cshtml"
using WebAPI7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57b435c36999f55b767655cd9f20cf2c6692d356", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c206015e37001786dceee75d8f1232f945cd6de0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Hello welcome to My API</h1>

<input id=""input"" list=""sug""/>
<datalist id=""sug""></datalist>
<button id=""adder"">Add</button>
<hr />
<div id=""div""></div>
<script>
    // quit leadership


    let input = document.getElementById(""input"");
    let div = document.getElementById(""div"");
    let adder = document.getElementById(""adder"");
    let sug = document.createElement(""sug"");
    let id = 0;

    adder.addEventListener(""click"", function () {
        fetch(""https://localhost:44353/api/user"", {  
            method: ""Post"",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                ""id"": id++,
                ""userName"": input.value,
            })
        })
        location.reload();
    })

    fetch(""https://localhost:44353/api/user"").then(function (res) {
        res.json().then(function (data) {
            let suggestions = search(data);
     ");
            WriteLiteral(@"       for (let i = 0; suggestions.length > i; i++) {
                let options = document.createElement(""option"");
                options.value = suggestions[i];
            }
        })
    })

    function search(data) {
        result = [];
        for (let i = 0; data.length > i; i++) {
            if (data[i].userName.startsWith(input.value)) {
                result.push(data[i].userName);
            }
        }
        return result;
    }
</script>
");
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
