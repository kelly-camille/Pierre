#pragma checksum "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ff7de300cb02b83aa43377bbb846acbaba2d6dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Delete), @"mvc.1.0.view", @"/Views/Flavors/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff7de300cb02b83aa43377bbb846acbaba2d6dd", @"/Views/Flavors/Delete.cshtml")]
    public class Views_Flavors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierre.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Are you sure you want to delete this Flavor</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.FlavorName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.FlavorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\r\n");
#nullable restore
#line 13 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Delete.cshtml"
Write(Html.ActionLink("Back to Flavors", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pierre.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
