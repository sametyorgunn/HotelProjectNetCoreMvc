#pragma checksum "C:\Users\asame\Desktop\.NetProjeler\HotelProject\RapidApi\RapidApiConsume\Views\Hotel\SearchHotelById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9391077f2071b76fea1e980b5ce1ef9073965b05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_SearchHotelById), @"mvc.1.0.view", @"/Views/Hotel/SearchHotelById.cshtml")]
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
#line 1 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\RapidApi\RapidApiConsume\Views\_ViewImports.cshtml"
using RapidApiConsume;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\RapidApi\RapidApiConsume\Views\Hotel\SearchHotelById.cshtml"
using RapidApiConsume.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9391077f2071b76fea1e980b5ce1ef9073965b05", @"/Views/Hotel/SearchHotelById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c3e56c32d2cd6b51a41f7a8813c7e2ce8cbc7de", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Hotel_SearchHotelById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HotelGetListViewModel.Result>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Hotel/SearchHotelById"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\RapidApi\RapidApiConsume\Views\Hotel\SearchHotelById.cshtml"
  
    ViewData["Title"] = "SearchHotelById";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css\" integrity=\"sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh\" crossorigin=\"anonymous\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9391077f2071b76fea1e980b5ce1ef9073965b054621", async() => {
                WriteLiteral("\r\n    <input name=\"id\" class=\"form-control\"/>\r\n    <button type=\"submit\">listele</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table class=\"table\">\r\n  <thead>\r\n    <tr>\r\n      <th scope=\"col\">#</th>\r\n      <th scope=\"col\">adi</th>\r\n      <th scope=\"col\">adres</th>\r\n      <th scope=\"col\">puan</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\RapidApi\RapidApiConsume\Views\Hotel\SearchHotelById.cshtml"
         foreach (var i in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <tr>\r\n              <th scope=\"row\">1</th>\r\n              <td>");
#nullable restore
#line 29 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\RapidApi\RapidApiConsume\Views\Hotel\SearchHotelById.cshtml"
             Write(i.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 30 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\RapidApi\RapidApiConsume\Views\Hotel\SearchHotelById.cshtml"
             Write(i.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td></td>\r\n             </tr>\r\n");
#nullable restore
#line 33 "C:\Users\asame\Desktop\.NetProjeler\HotelProject\RapidApi\RapidApiConsume\Views\Hotel\SearchHotelById.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HotelGetListViewModel.Result>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
