#pragma checksum "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\API12\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bf18dfd5039ce061df269712bb3b4c29761ea5f"
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
#line 1 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\API12\Views\_ViewImports.cshtml"
using API12;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\API12\Views\_ViewImports.cshtml"
using API12.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf18dfd5039ce061df269712bb3b4c29761ea5f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b7324ca76c10aa535d6194253ad757dd573dc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jdubula\Desktop\100dayofcodeDay00-js-\API12\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Hello, Welcome to My api</h1>
<input id=""input""/>
<button id=""add"">Add</button>
<hr />
<div id=""div""></div>

<script>
    let input = document.getElementById(""input"");
    let add = document.getElementById(""add"");
    let div = document.querySelector(""#div"");
    let id = 1;


    add.addEventListener(""click"", function () {
            fetch(`https://localhost:44321/api/user/`, {
                method: ""Post"",
                headers: {
                    ""Accept"": ""application/json"",
                    ""Content-Type"": ""application/json"",
                },
                body: JSON.stringify({
                    ""userID"": id++,
                    ""userName"": input.value,
                })
            })
            location.reload();
        })
   

    fetch(""https://localhost:44321/api/user"").then(function (res) {
        res.json().then(function (data) {
            for (let i = 0; data.length > i; i++) {
                let li = document.createElement(""li"");
");
            WriteLiteral(@"                let editButton = document.createElement(""button"");
                editButton.innerHTML = ""edit"";
                editButton.addEventListener(""click"", function () {
                    fetch(`https://localhost:44321/api/user/${data[i].userID}/${input.value}`, {
                        method: ""PUT"",
                        headers: {
                            ""Accept"": ""application/json"",
                            ""Content-type"" : ""application/json"",
                        }
                    })
                    location.reload();
                })
                let deleteButton = document.createElement(""button"");
                deleteButton.innerHTML = ""delete""
                deleteButton.addEventListener(""click"", function () {
                    fetch(`https://localhost:44321/api/user/${data[i].userID}`, {
                        method: ""delete"",
                        headers: {
                            ""Accept"": ""application/json"",
                  ");
            WriteLiteral(@"          ""Content-type"": ""application/json"",
                        }
                    })
                    location.reload();
                })
                li.innerHTML = data[i].userName;
                div.append(li);
                div.append(editButton);
                div.append(deleteButton);
            }
        })
    })
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