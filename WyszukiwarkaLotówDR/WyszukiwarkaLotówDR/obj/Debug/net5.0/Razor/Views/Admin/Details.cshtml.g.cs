#pragma checksum "C:\Users\oladr\Downloads\WyszukiwarkaLotówDR (1)\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69e6f8fc7b4201771f33aa8bafa4a68776624c1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
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
#line 1 "C:\Users\oladr\Downloads\WyszukiwarkaLotówDR (1)\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\_ViewImports.cshtml"
using WyszukiwarkaLotówDR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oladr\Downloads\WyszukiwarkaLotówDR (1)\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\_ViewImports.cshtml"
using WyszukiwarkaLotówDR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e6f8fc7b4201771f33aa8bafa4a68776624c1c", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecb5927692b36ef689e826d4dad72dca1ec77173", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WyszukiwarkaLotówDR.Loty.Lot>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\oladr\Downloads\WyszukiwarkaLotówDR (1)\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Szczegóły</h1>\r\n\r\n<div>\r\n    <h4>Lot</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-2\">\r\n            Data i czas wylotu\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\oladr\Downloads\WyszukiwarkaLotówDR (1)\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.czasWylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Data i czas przylotu\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\oladr\Downloads\WyszukiwarkaLotówDR (1)\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.czasPrzylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Miejsce wylotu\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\oladr\Downloads\WyszukiwarkaLotówDR (1)\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.miejsceWylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Miejsce przylotu\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\oladr\Downloads\WyszukiwarkaLotówDR (1)\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.miejscePrzylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Lotnisko początkowe\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\oladr\Downloads\WyszukiwarkaLotówDR (1)\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.kodLotniskaWylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Lotnisko końcowe\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\oladr\Downloads\WyszukiwarkaLotówDR (1)\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.kodLotniskaPrzylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Cena 1 biletu\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\oladr\Downloads\WyszukiwarkaLotówDR (1)\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.cenaBiletu));

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Ilość wolnych miejsc\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\oladr\Downloads\WyszukiwarkaLotówDR (1)\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.iloscMiejsc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69e6f8fc7b4201771f33aa8bafa4a68776624c1c7968", async() => {
                WriteLiteral("Powrót do listy lotów");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WyszukiwarkaLotówDR.Loty.Lot> Html { get; private set; }
    }
}
#pragma warning restore 1591
