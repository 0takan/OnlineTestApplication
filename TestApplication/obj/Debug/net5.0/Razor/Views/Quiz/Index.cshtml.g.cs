#pragma checksum "D:\1\OnlineTestApplication\TestApplication\Views\Quiz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed068def84729d480a5ce6e7598f60937fcddeb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Index), @"mvc.1.0.view", @"/Views/Quiz/Index.cshtml")]
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
#line 1 "D:\1\OnlineTestApplication\TestApplication\Views\_ViewImports.cshtml"
using TestApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\1\OnlineTestApplication\TestApplication\Views\_ViewImports.cshtml"
using TestApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed068def84729d480a5ce6e7598f60937fcddeb5", @"/Views/Quiz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c18df14659d9ffcf730f540f4c694666d270b7cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestApplication.Areas.Identity.Data.Quiz>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\1\OnlineTestApplication\TestApplication\Views\Quiz\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed068def84729d480a5ce6e7598f60937fcddeb53742", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""sweetalert2.all.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.js""></script>
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.css"">
<script src=""https://cdn.jsdelivr.net/npm/sweetalert2@11""></script>


<script type=""text/javascript"">
    $(document).ready(function () {
        $("".btnalertMessage"").click(function () {
            Swal.fire({
                title: 'Are you ready to start ?',
                input: 'checkbox',
                inputPlaceholder: 'I agree to start'
            }).then((result) => {
                if (result.isConfirmed) {
                    if (result.value) {
                        Swal.fire({ icon: 'success', text: 'You agree with rules' });
                    } else {
                        Swal.fire({ icon: 'error', text: ""Permission denied"" });
                    }
                } else {
                    console.log(`modal w");
            WriteLiteral("as dismissed by ${result.dismiss}`)\r\n                }\r\n            })\r\n        });\r\n    });\r\n</script>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("    <div class=\"container\" style=\"display: flex;\">\r\n");
#nullable restore
#line 42 "D:\1\OnlineTestApplication\TestApplication\Views\Quiz\Index.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"width: 18rem; margin:8px;\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1556, "\"", 1575, 1);
#nullable restore
#line 46 "D:\1\OnlineTestApplication\TestApplication\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 1562, item.QuizImg, 1562, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 48 "D:\1\OnlineTestApplication\TestApplication\Views\Quiz\Index.cshtml"
                                      Write(item.QuizName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 49 "D:\1\OnlineTestApplication\TestApplication\Views\Quiz\Index.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a href=\"#\" class=\"btn btn-primary btnalertMessage\">Start</a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 53 "D:\1\OnlineTestApplication\TestApplication\Views\Quiz\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestApplication.Areas.Identity.Data.Quiz>> Html { get; private set; }
    }
}
#pragma warning restore 1591