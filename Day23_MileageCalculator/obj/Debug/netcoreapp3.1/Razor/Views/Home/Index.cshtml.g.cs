#pragma checksum "D:\Bootcamp\Examples\Day23_MileageCalculator\Day23_MileageCalculator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa14f496a82d1ae6b8d52215f38a24e96ca092ee"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa14f496a82d1ae6b8d52215f38a24e96ca092ee", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc4c4c1e3e0aa4f2641bfaba590a735bb7ae36c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Bootcamp\Examples\Day23_MileageCalculator\Day23_MileageCalculator\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
	<ul class=""noBulletList"">
		<lh class=""display-4"">Choose a web app to sample</></lh>
		<li><p>Click <a runat=""server"" href=""Home/MileageCalculator"">here</a> for the mileage calculator.</p></li>
		<li><p>Click <a runat=""server"" href=""Home/Calculator"">here</a> for the calculator.</p></li>
		<li><p>Click <a runat=""server"" href=""Home/Division"">here</a> to do division with a remainder.</p></li>
		<li><p>Click <a runat=""server"" href=""Home/RomanNumeral"">here</a> to covert a number to a Roman Numeral.</p></li>
	</ul>
</div>
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
