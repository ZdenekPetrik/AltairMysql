#pragma checksum "d:\Aplikace\Git\AltairMysql\AltairMysqlDemo\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "254b6b3b5050f1bc39802554f643801eca6c0543"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AltairMysqlDemo.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AltairMysqlDemo.Pages
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
#line 1 "d:\Aplikace\Git\AltairMysql\AltairMysqlDemo\Pages\_ViewImports.cshtml"
using AltairMysqlDemo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"254b6b3b5050f1bc39802554f643801eca6c0543", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ddd6670c1ed6feb489c7c4da02ef6bb8ec524a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "d:\Aplikace\Git\AltairMysql\AltairMysqlDemo\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n\r\n    <h1>MultiDB. Demo: Contacts</h1>\r\n    <table >\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 13 "d:\Aplikace\Git\AltairMysql\AltairMysqlDemo\Pages\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Contacts.FirstOrDefault().LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 14 "d:\Aplikace\Git\AltairMysql\AltairMysqlDemo\Pages\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Contacts.FirstOrDefault().FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 15 "d:\Aplikace\Git\AltairMysql\AltairMysqlDemo\Pages\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Contacts.FirstOrDefault().EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 16 "d:\Aplikace\Git\AltairMysql\AltairMysqlDemo\Pages\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Contacts.FirstOrDefault().PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 20 "d:\Aplikace\Git\AltairMysql\AltairMysqlDemo\Pages\Index.cshtml"
             foreach (var item in Model.Contacts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 24 "d:\Aplikace\Git\AltairMysql\AltairMysqlDemo\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 27 "d:\Aplikace\Git\AltairMysql\AltairMysqlDemo\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "d:\Aplikace\Git\AltairMysql\AltairMysqlDemo\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "d:\Aplikace\Git\AltairMysql\AltairMysqlDemo\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "d:\Aplikace\Git\AltairMysql\AltairMysqlDemo\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n\r\n    </table>\r\n    <footer></footer>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
