#pragma checksum "C:\Users\enes.gur\Desktop\CreatingDynamicJson_.NetCoreMVC\CreatingDynamicJson\CreateingDynamicJson.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d67176f787ed1722ff50bc505f935ec436deca8"
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
#line 1 "C:\Users\enes.gur\Desktop\CreatingDynamicJson_.NetCoreMVC\CreatingDynamicJson\CreateingDynamicJson.UI\Views\_ViewImports.cshtml"
using CreatingDynamicJson.UI;

#line default
#line hidden
#line 2 "C:\Users\enes.gur\Desktop\CreatingDynamicJson_.NetCoreMVC\CreatingDynamicJson\CreateingDynamicJson.UI\Views\_ViewImports.cshtml"
using CreatingDynamicJson.UI.Models;

#line default
#line hidden
#line 2 "C:\Users\enes.gur\Desktop\CreatingDynamicJson_.NetCoreMVC\CreatingDynamicJson\CreateingDynamicJson.UI\Views\Home\Index.cshtml"
using CreatingDynamicJson.UI.Helper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d67176f787ed1722ff50bc505f935ec436deca8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05897543612aa65d5ccc953ceda0d9c85402db10", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreatingDynamicJson.UI.Models.Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\enes.gur\Desktop\CreatingDynamicJson_.NetCoreMVC\CreatingDynamicJson\CreateingDynamicJson.UI\Views\Home\Index.cshtml"
  
    var jsonData = Model.CreateDynamicJson();

#line default
#line hidden
#line 6 "C:\Users\enes.gur\Desktop\CreatingDynamicJson_.NetCoreMVC\CreatingDynamicJson\CreateingDynamicJson.UI\Views\Home\Index.cshtml"
 if (jsonData != null)
{
        

#line default
#line hidden
#line 8 "C:\Users\enes.gur\Desktop\CreatingDynamicJson_.NetCoreMVC\CreatingDynamicJson\CreateingDynamicJson.UI\Views\Home\Index.cshtml"
   Write(Html.Raw(jsonData));

#line default
#line hidden
#line 8 "C:\Users\enes.gur\Desktop\CreatingDynamicJson_.NetCoreMVC\CreatingDynamicJson\CreateingDynamicJson.UI\Views\Home\Index.cshtml"
                           ;

}

#line default
#line hidden
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreatingDynamicJson.UI.Models.Author> Html { get; private set; }
    }
}
#pragma warning restore 1591
