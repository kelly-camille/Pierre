#pragma checksum "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\AddTreat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bef4d9a019fff0d36815484fa9ac7df626fb89a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_AddTreat), @"mvc.1.0.view", @"/Views/Flavors/AddTreat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef4d9a019fff0d36815484fa9ac7df626fb89a4", @"/Views/Flavors/AddTreat.cshtml")]
    public class Views_Flavors_AddTreat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierre.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\AddTreat.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Add a treat</h2>\r\n\r\n<h4>Add a treat to the flavor: ");
#nullable restore
#line 9 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\AddTreat.cshtml"
                          Write(Html.DisplayFor(ModelExpressionProvider => ModelExpressionProvider.FlavorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\AddTreat.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\AddTreat.cshtml"
Write(Html.HiddenFor(model => model.FlavorId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\AddTreat.cshtml"
Write(Html.Label("Select treat"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\AddTreat.cshtml"
Write(Html.DropDownList("TreatId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\r\n");
#nullable restore
#line 19 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\AddTreat.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 21 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\AddTreat.cshtml"
Write(Html.ActionLink("Back", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
