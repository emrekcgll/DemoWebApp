#pragma checksum "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceb5401d79ab245893d71755f5a816fbba6997de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Index), @"mvc.1.0.view", @"/Views/Food/Index.cshtml")]
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
#line 1 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
using DataAccessLayer.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceb5401d79ab245893d71755f5a816fbba6997de", @"/Views/Food/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Food_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Food Name</th>
        <th>Price</th>
        <th>Stock</th>
        <th>Category Name</th>
        <th>Update</th>
        <th>Details</th>
        <th>Delete</th>

    </tr>
");
#nullable restore
#line 25 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
           Write(item.FoodId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
           Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 741, "\"", 777, 2);
            WriteAttributeValue("", 748, "/Food/UpdateFood/", 748, 17, true);
#nullable restore
#line 34 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
WriteAttributeValue("", 765, item.FoodId, 765, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-info\">Details</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 905, "\"", 941, 2);
            WriteAttributeValue("", 912, "/Food/DeleteFood/", 912, 17, true);
#nullable restore
#line 36 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
WriteAttributeValue("", 929, item.FoodId, 929, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Food/AddFood/\" class=\"btn btn-primary\">New Food</a>\r\n");
#nullable restore
#line 42 "C:\Users\Emre\OneDrive\Masaüstü\WebRestaurantApp\WebRestaurantApp\Views\Food\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
