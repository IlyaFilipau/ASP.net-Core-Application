#pragma checksum "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Profile\AdminDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8895a3809f8f84179e9f381c2ffb3c3981b87c24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_AdminDelete), @"mvc.1.0.view", @"/Views/Profile/AdminDelete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/AdminDelete.cshtml", typeof(AspNetCore.Views_Profile_AdminDelete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8895a3809f8f84179e9f381c2ffb3c3981b87c24", @"/Views/Profile/AdminDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_AdminDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.coursework.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Profile\AdminDelete.cshtml"
  
    ViewBag.Title = "DeleteCustomer";

#line default
#line hidden
            BeginContext(90, 103, true);
            WriteLiteral("\r\n<div>\r\n    <br />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>Login</dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(194, 45, false);
#line 11 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Profile\AdminDelete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerLogin));

#line default
#line hidden
            EndContext();
            BeginContext(239, 72, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>Password</dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(312, 48, false);
#line 16 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Profile\AdminDelete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerPassword));

#line default
#line hidden
            EndContext();
            BeginContext(360, 69, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>Email</dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(430, 45, false);
#line 21 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Profile\AdminDelete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerEmail));

#line default
#line hidden
            EndContext();
            BeginContext(475, 68, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>Role</dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(544, 41, false);
#line 26 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Profile\AdminDelete.cshtml"
       Write(Html.DisplayFor(model => model.Role.Name));

#line default
#line hidden
            EndContext();
            BeginContext(585, 69, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>Score</dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(655, 45, false);
#line 31 "C:\Users\Lenovo\source\repos\WebApplication2\WebApplication2\Views\Profile\AdminDelete.cshtml"
       Write(Html.DisplayFor(model => model.CustomerScore));

#line default
#line hidden
            EndContext();
            BeginContext(700, 51, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(751, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26d52a62829647e8aaff05cf931f5234", async() => {
                BeginContext(821, 148, true);
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
            BeginContext(976, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.coursework.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
