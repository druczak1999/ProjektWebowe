#pragma checksum "C:\Users\oladr\source\repos\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f134afa3945ae37d5b39e817d289623f9835b13"
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
#line 1 "C:\Users\oladr\source\repos\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\_ViewImports.cshtml"
using WyszukiwarkaLotówDR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oladr\source\repos\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\_ViewImports.cshtml"
using WyszukiwarkaLotówDR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f134afa3945ae37d5b39e817d289623f9835b13", @"/Views/Admin/Details.cshtml")]
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\oladr\source\repos\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Szczegóły</h1>\n\n<div>\n    <h4>Lot</h4>\n    <hr />\n    <dl class=\"row\">\n\n        <dt class=\"col-sm-2\">\n            Data i czas wylotu\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 18 "C:\Users\oladr\source\repos\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.czasWylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Data i czas przylotu\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 24 "C:\Users\oladr\source\repos\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.czasPrzylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Miejsce wylotu\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 30 "C:\Users\oladr\source\repos\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.miejsceWylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Miejsce przylotu\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 36 "C:\Users\oladr\source\repos\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.miejscePrzylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Lotnisko początkowe\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 42 "C:\Users\oladr\source\repos\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.kodLotniskaWylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Lotnisko końcowe\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 48 "C:\Users\oladr\source\repos\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.kodLotniskaPrzylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Cena 1 biletu\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 54 "C:\Users\oladr\source\repos\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.cenaBiletu));

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł\n        </dd>\n        <dt class=\"col-sm-2\">\n            Ilość wolnych miejsc\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 60 "C:\Users\oladr\source\repos\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(model => model.iloscMiejsc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f134afa3945ae37d5b39e817d289623f9835b137112", async() => {
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
            WriteLiteral("\n</div>\n");
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
