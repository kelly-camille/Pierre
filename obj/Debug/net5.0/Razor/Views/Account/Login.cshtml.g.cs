#pragma checksum "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "096f6a88a8498ee4fd76e8a2be3b52659a348699"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 5 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Account\Login.cshtml"
using Pierre.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"096f6a88a8498ee4fd76e8a2be3b52659a348699", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Account\Login.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Log in with your account</h2>\r\n<hr />\r\n");
#nullable restore
#line 11 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Account\Login.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Account\Login.cshtml"
Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Account\Login.cshtml"
Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Account\Login.cshtml"
Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Account\Login.cshtml"
Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Log in\" class=\"btn btn-default\" />\r\n");
#nullable restore
#line 20 "C:\Users\kelly\OneDrive\Desktop\Pierre\Views\Account\Login.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
