#pragma checksum "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e26f34259bfa915469188790a86ed6afb9b1a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e26f34259bfa915469188790a86ed6afb9b1a1", @"/Views/Category/Index.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreYiyecekler.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Category List</h1>\r\n<br />\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Category Name</th>\r\n          <th>Status</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n      \r\n    <tr />\r\n");
#nullable restore
#line 21 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\Index.cshtml"
     foreach (var x in Model)
    {




#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\Index.cshtml"
           Write(x.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\Index.cshtml"
           Write(x.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\Index.cshtml"
           Write(x.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-info\">Update</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<a href=\"/Category/CategoryAdd\" class=\"btn btn-info\">New Category</a>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreYiyecekler.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
