#pragma checksum "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Default\Components\CategoryGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb8373a52707fa96669f40a9d00c17bf57494534"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_CategoryGetList_Default), @"mvc.1.0.view", @"/Views/Default/Components/CategoryGetList/Default.cshtml")]
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
#line 1 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Default\Components\CategoryGetList\Default.cshtml"
using DataAccessLayer.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8373a52707fa96669f40a9d00c17bf57494534", @"/Views/Default/Components/CategoryGetList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_Components_CategoryGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"collapse navbar-collapse\" id=\"bs-megadropdown-tabs\">\r\n    <ul class=\"nav navbar-nav nav_1\">\r\n");
#nullable restore
#line 6 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Default\Components\CategoryGetList\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 235, "\"", 283, 2);
            WriteAttributeValue("", 242, "/Default/CategoryDetails/", 242, 25, true);
#nullable restore
#line 8 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Default\Components\CategoryGetList\Default.cshtml"
WriteAttributeValue("", 267, item.CategoryId, 267, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Default\Components\CategoryGetList\Default.cshtml"
                                                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 9 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Default\Components\CategoryGetList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
