#pragma checksum "D:\Bootcamp\Examples\Day23_MileageCalculator\Day23_MileageCalculator\Views\Home\DivisionResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5c1cce19f3f6b856902b5567b1fb42103d7c185"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DivisionResult), @"mvc.1.0.view", @"/Views/Home/DivisionResult.cshtml")]
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
#line 1 "D:\Bootcamp\Examples\Day23_MileageCalculator\Day23_MileageCalculator\Views\_ViewImports.cshtml"
using Day23_MileageCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bootcamp\Examples\Day23_MileageCalculator\Day23_MileageCalculator\Views\_ViewImports.cshtml"
using Day23_MileageCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5c1cce19f3f6b856902b5567b1fb42103d7c185", @"/Views/Home/DivisionResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc4c4c1e3e0aa4f2641bfaba590a735bb7ae36c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DivisionResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Division>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("DivisionResult"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Bootcamp\Examples\Day23_MileageCalculator\Day23_MileageCalculator\Views\Home\DivisionResult.cshtml"
  
    ViewData["Title"] = "Division";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 8 "D:\Bootcamp\Examples\Day23_MileageCalculator\Day23_MileageCalculator\Views\Home\DivisionResult.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5c1cce19f3f6b856902b5567b1fb42103d7c1854450", async() => {
                WriteLiteral("\r\n        First number: <input type=\"number\" name=\"x\"");
                BeginWriteAttribute("value", " value=", 310, "", 325, 1);
#nullable restore
#line 10 "D:\Bootcamp\Examples\Day23_MileageCalculator\Day23_MileageCalculator\Views\Home\DivisionResult.cshtml"
WriteAttributeValue("", 317, Model.X, 317, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        Second number: <input type=\"number\" name=\"y\"");
                BeginWriteAttribute("value", " value=", 382, "", 397, 1);
#nullable restore
#line 11 "D:\Bootcamp\Examples\Day23_MileageCalculator\Day23_MileageCalculator\Views\Home\DivisionResult.cshtml"
WriteAttributeValue("", 389, Model.Y, 389, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"submit\" value=\"Calculate\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 14 "D:\Bootcamp\Examples\Day23_MileageCalculator\Day23_MileageCalculator\Views\Home\DivisionResult.cshtml"
Write(Model.X);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 14 "D:\Bootcamp\Examples\Day23_MileageCalculator\Day23_MileageCalculator\Views\Home\DivisionResult.cshtml"
          Write(Model.Y);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 14 "D:\Bootcamp\Examples\Day23_MileageCalculator\Day23_MileageCalculator\Views\Home\DivisionResult.cshtml"
                     Write(Model.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with a remainder of ");
#nullable restore
#line 14 "D:\Bootcamp\Examples\Day23_MileageCalculator\Day23_MileageCalculator\Views\Home\DivisionResult.cshtml"
                                                       Write(Model.Remainder);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Division> Html { get; private set; }
    }
}
#pragma warning restore 1591
