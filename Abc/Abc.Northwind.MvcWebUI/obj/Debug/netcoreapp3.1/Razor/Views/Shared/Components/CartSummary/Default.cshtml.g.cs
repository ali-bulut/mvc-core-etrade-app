#pragma checksum "C:\Workspace\Mvc Core Kurumsal Mimari\Abc\Abc.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be4d87c8946ff8081590c944a8df2884710b86b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4d87c8946ff8081590c944a8df2884710b86b8", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a9be6fbfb05261effc62825f5bba4e631adc400", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abc.Northwind.MvcWebUI.Models.CartSummaryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Workspace\Mvc Core Kurumsal Mimari\Abc\Abc.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"dropdown-menu dropdown-menu-right\" aria-labelledby=\"navbarDropdown\">\r\n");
#nullable restore
#line 7 "C:\Workspace\Mvc Core Kurumsal Mimari\Abc\Abc.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
         foreach (var item in Model.Cart.CartLines)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"dropdown-item\" href=\"#\">");
#nullable restore
#line 9 "C:\Workspace\Mvc Core Kurumsal Mimari\Abc\Abc.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
                                         Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge\">");
#nullable restore
#line 9 "C:\Workspace\Mvc Core Kurumsal Mimari\Abc\Abc.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
                                                                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n");
#nullable restore
#line 10 "C:\Workspace\Mvc Core Kurumsal Mimari\Abc\Abc.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"dropdown-divider\"></div>\r\n\r\n        <a class=\"dropdown-item\" href=\"#\"><span class=\"glyphicon glyphicon-shopping-cart\"></span>");
#nullable restore
#line 14 "C:\Workspace\Mvc Core Kurumsal Mimari\Abc\Abc.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
                                                                                            Write(Model.Cart.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n        <div class=\"dropdown-divider\"></div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be4d87c8946ff8081590c944a8df2884710b86b85990", async() => {
                WriteLiteral("Go to Cart Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abc.Northwind.MvcWebUI.Models.CartSummaryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
