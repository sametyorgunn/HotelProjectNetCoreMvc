#pragma checksum "C:\Users\asame\Desktop\.NetProjeler\HotelProject\Frontend\HotelProject.WebUI\Areas\Admin\Views\AdminService\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "662c45e2e9a25b6524c5e4453dfc5a24f3b257a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminService_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminService/Index.cshtml")]
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
#line 1 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\Frontend\HotelProject.WebUI\Areas\Admin\Views\AdminService\Index.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"662c45e2e9a25b6524c5e4453dfc5a24f3b257a3", @"/Areas/Admin/Views/AdminService/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminService_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultServiceDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\Frontend\HotelProject.WebUI\Areas\Admin\Views\AdminService\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Resim</th>\r\n        <th>Başlık</th>\r\n        <th>Açıklama</th>\r\n        <th>Düzenle</th>\r\n        <th>Sil</th>\r\n\r\n    </tr>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\Frontend\HotelProject.WebUI\Areas\Admin\Views\AdminService\Index.cshtml"
         foreach (var i in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\Frontend\HotelProject.WebUI\Areas\Admin\Views\AdminService\Index.cshtml"
               Write(i.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\Frontend\HotelProject.WebUI\Areas\Admin\Views\AdminService\Index.cshtml"
               Write(i.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\Frontend\HotelProject.WebUI\Areas\Admin\Views\AdminService\Index.cshtml"
               Write(i.ServiceIcon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 588, "\"", 626, 2);
            WriteAttributeValue("", 595, "/Staff/UpdateStaff/", 595, 19, true);
#nullable restore
#line 27 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\Frontend\HotelProject.WebUI\Areas\Admin\Views\AdminService\Index.cshtml"
WriteAttributeValue("", 614, i.ServiceId, 614, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Düzenle</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 689, "\"", 727, 2);
            WriteAttributeValue("", 696, "/Staff/DeleteStaff/", 696, 19, true);
#nullable restore
#line 28 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\Frontend\HotelProject.WebUI\Areas\Admin\Views\AdminService\Index.cshtml"
WriteAttributeValue("", 715, i.ServiceId, 715, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\Frontend\HotelProject.WebUI\Areas\Admin\Views\AdminService\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"/Staff/AddStaff\" class=\"btn mb-1 btn-rounded btn-outline-info\">Yeni Personel Ekle</a>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultServiceDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
