#pragma checksum "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d86226141dbaa8483b1b4da77766fce4ab57cb89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BazaLotów_Index), @"mvc.1.0.view", @"/Views/BazaLotów/Index.cshtml")]
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
#line 1 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\_ViewImports.cshtml"
using WyszukiwarkaLotówDR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\_ViewImports.cshtml"
using WyszukiwarkaLotówDR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d86226141dbaa8483b1b4da77766fce4ab57cb89", @"/Views/BazaLotów/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecb5927692b36ef689e826d4dad72dca1ec77173", @"/Views/_ViewImports.cshtml")]
    public class Views_BazaLotów_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WyszukiwarkaLotówDR.Loty.Lot>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Wyszukiwarka lotów</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d86226141dbaa8483b1b4da77766fce4ab57cb894489", async() => {
                WriteLiteral("\r\n    <div class=\"form-actions no-color\">\r\n        <p>\r\n            Wpisz miejsce wylotu: <input type=\"text\" name=\"mWylotu\"");
                BeginWriteAttribute("value", " value=\"", 287, "\"", 313, 1);
#nullable restore
#line 12 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
WriteAttributeValue("", 295, ViewData["Wylot"], 295, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            Wpisz miejsce przylotu: <input type=\"text\" name=\"mPrzylotu\"");
                BeginWriteAttribute("value", " value=\"", 390, "\"", 418, 1);
#nullable restore
#line 13 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
WriteAttributeValue("", 398, ViewData["Przylot"], 398, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <div class=\"md-form md-outline input-with-post-icon datepicker\">\r\n                Podaj datę wylotu: <input placeholder=\"Select date\" type=\"date\" id=\"example\" class=\"form-control\" name=\"data\"");
                BeginWriteAttribute("value", " value=\"", 627, "\"", 658, 1);
#nullable restore
#line 15 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
WriteAttributeValue("", 635, ViewData["DataWylotu"], 635, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <input type=\"submit\" value=\"Szukaj\" class=\"btn btn-default\" />\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d86226141dbaa8483b1b4da77766fce4ab57cb896613", async() => {
                    WriteLiteral("Pokaż pełną listę lotów");
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
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th></th>\r\n                <th>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d86226141dbaa8483b1b4da77766fce4ab57cb899403", async() => {
#nullable restore
#line 29 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
                                                                                     Write(Html.DisplayNameFor(model => model.czasWylotu));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
                                                   WriteLiteral(ViewData["DataSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Data przylotu\r\n                </th>\r\n                <th>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d86226141dbaa8483b1b4da77766fce4ab57cb8912169", async() => {
                WriteLiteral("Miejsce wylotu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
                                                   WriteLiteral(ViewData["NameSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Miejsce przylotu\r\n                </th>\r\n\r\n                <th>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d86226141dbaa8483b1b4da77766fce4ab57cb8914600", async() => {
                WriteLiteral(" ");
#nullable restore
#line 42 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
                                                                                      Write(Html.DisplayNameFor(model => model.cenaBiletu));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
                                                   WriteLiteral(ViewData["CenaSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </th>\r\n\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <img src=\"https://mdbootstrap.com/img/Photos/Slides/img%20(45).jpg\" width=\"50\" height=\"30\" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.czasWylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.czasPrzylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.miejsceWylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.miejscePrzylotu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 69 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.cenaBiletu));

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł\r\n                    </td>\r\n\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 74 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
                   Write(Html.ActionLink("Szczegóły", "Details", new { id = item.idLotu }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 78 "C:\Users\1999a\Downloads\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\WyszukiwarkaLotówDR\Views\BazaLotów\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WyszukiwarkaLotówDR.Loty.Lot>> Html { get; private set; }
    }
}
#pragma warning restore 1591
