#pragma checksum "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\CategoryAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84a8ce170cbb9660e1d0c80b9bc68e18e7dd2a4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryAdd), @"mvc.1.0.view", @"/Views/Category/CategoryAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84a8ce170cbb9660e1d0c80b9bc68e18e7dd2a4c", @"/Views/Category/CategoryAdd.cshtml")]
    public class Views_Category_CategoryAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreYiyecekler.Data.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\CategoryAdd.cshtml"
  
    ViewData["Title"] = "CategoryAdd";
     Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CategoryAdd</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\CategoryAdd.cshtml"
 using (Html.BeginForm("CategoryAdd", "Category", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\CategoryAdd.cshtml"
Write(Html.LabelFor(x => x.CategoryName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\CategoryAdd.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\CategoryAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.CategoryName, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br/>\r\n");
#nullable restore
#line 15 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\CategoryAdd.cshtml"
Write(Html.LabelFor(x => x.CategoryDescription));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\CategoryAdd.cshtml"
Write(Html.TextBoxFor(x => x.CategoryDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n<button class=\"btn btn-info\">Save</button>\r\n");
#nullable restore
#line 19 "C:\Users\Kızılkafa\source\repos\CoreYiyecekler\CoreYiyecekler\Views\Category\CategoryAdd.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreYiyecekler.Data.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
