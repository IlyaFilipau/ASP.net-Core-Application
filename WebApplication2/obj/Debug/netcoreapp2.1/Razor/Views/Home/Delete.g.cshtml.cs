#pragma checksum "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf32b03cbee5ca33ae2a86ab6d9aae8083e38c59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Delete.cshtml", typeof(AspNetCore.Views_Home_Delete))]
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
#line 1 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf32b03cbee5ca33ae2a86ab6d9aae8083e38c59", @"/Views/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.coursework.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Home\Delete.cshtml"
  
    ViewBag.Title = "Delete Product";

#line default
#line hidden
            BeginContext(89, 19, true);
            WriteLiteral("<br/>\r\n<h2>Product ");
            EndContext();
            BeginContext(109, 17, false);
#line 6 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Home\Delete.cshtml"
       Write(Model.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(126, 62, true);
            WriteLiteral("</h2>\r\n<div>\r\n    <dl>\r\n\r\n        <dt>Price</dt>\r\n        <dd>");
            EndContext();
            BeginContext(189, 11, false);
#line 11 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Home\Delete.cshtml"
       Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(200, 45, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Genre</dt>\r\n        <dd>");
            EndContext();
            BeginContext(246, 21, false);
#line 14 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Home\Delete.cshtml"
       Write(Model.Genre.GenreName);

#line default
#line hidden
            EndContext();
            BeginContext(267, 46, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Series</dt>\r\n        <dd>");
            EndContext();
            BeginContext(314, 23, false);
#line 17 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Home\Delete.cshtml"
       Write(Model.Series.SeriesName);

#line default
#line hidden
            EndContext();
            BeginContext(337, 48, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Category</dt>\r\n        <dd>");
            EndContext();
            BeginContext(386, 27, false);
#line 20 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Home\Delete.cshtml"
       Write(Model.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(413, 52, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Manufacturer</dt>\r\n        <dd>");
            EndContext();
            BeginContext(466, 35, false);
#line 23 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Home\Delete.cshtml"
       Write(Model.Manufacturer.ManufacturerName);

#line default
#line hidden
            EndContext();
            BeginContext(501, 49, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Publisher</dt>\r\n        <dd>");
            EndContext();
            BeginContext(551, 29, false);
#line 26 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Home\Delete.cshtml"
       Write(Model.Publisher.PublisherName);

#line default
#line hidden
            EndContext();
            BeginContext(580, 50, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Age Rating</dt>\r\n        <dd>");
            EndContext();
            BeginContext(631, 22, false);
#line 29 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Home\Delete.cshtml"
       Write(Model.ProductAgeRating);

#line default
#line hidden
            EndContext();
            BeginContext(653, 50, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Evaluation</dt>\r\n        <dd>");
            EndContext();
            BeginContext(704, 23, false);
#line 32 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Home\Delete.cshtml"
       Write(Model.ProductEvaluation);

#line default
#line hidden
            EndContext();
            BeginContext(727, 50, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Issue Date</dt>\r\n        <dd>");
            EndContext();
            BeginContext(778, 22, false);
#line 35 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Home\Delete.cshtml"
       Write(Model.ProductIssueDate);

#line default
#line hidden
            EndContext();
            BeginContext(800, 39, true);
            WriteLiteral("</dd>\r\n    </dl>\r\n\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(839, 217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dc1f794b0bf4088b4051e3c2557d2e5", async() => {
                BeginContext(901, 148, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" class=\"btn btn-default\" value=\"Delete\" />\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1056, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.coursework.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
