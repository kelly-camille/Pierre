#pragma checksum "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b736bafe254a5cb2900e2f007ebc6536b07eb590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Create), @"mvc.1.0.view", @"/Views/Flavors/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b736bafe254a5cb2900e2f007ebc6536b07eb590", @"/Views/Flavors/Create.cshtml")]
    public class Views_Flavors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierre.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h4>Add a new flavor</h4>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Create.cshtml"
Write(Html.LabelFor(model => model.FlavorName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Create.cshtml"
Write(Html.TextBoxFor(model => model.FlavorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add new flavor\" class=\"btn btn-default\" />\r\n");
#nullable restore
#line 20 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 21 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Flavors\Create.cshtml"
Write(Html.ActionLink("Show all flavors", "Index"));

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
