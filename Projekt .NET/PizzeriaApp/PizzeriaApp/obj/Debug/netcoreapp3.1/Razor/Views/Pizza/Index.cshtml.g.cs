#pragma checksum "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60e0399df5831e759937ee375530afed5729fd38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Index), @"mvc.1.0.view", @"/Views/Pizza/Index.cshtml")]
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
#line 1 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\_ViewImports.cshtml"
using PizzeriaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\_ViewImports.cshtml"
using PizzeriaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e0399df5831e759937ee375530afed5729fd38", @"/Views/Pizza/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80ad077a0d5277b521cceb1d09bff68dbe5e3d23", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzeriaApp.Models.AllDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PizzaTopping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
  
    ViewData["Title"] = "Menu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Pizze</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60e0399df5831e759937ee375530afed5729fd385394", async() => {
                WriteLiteral("Nowa pizza");
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
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 13 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
 using (Html.BeginForm("Index", "Pizza", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"input-group mb-3\">\r\n        <input class=\"form-control w-25\"\r\n               id=\"searchName\"\r\n               name=\"searchName\"\r\n               type=\"text\"\r\n               placeholder=\"Wyszukaj...\"");
            BeginWriteAttribute("value", "\r\n               value=\"", 433, "\"", 457, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <div class=\"input-group-append\">\r\n            <input type=\"submit\"\r\n                   value=\"Szukaj\"\r\n                   class=\"btn btn-primary\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 28 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"col-lg-4\">\r\n                Nazwa\r\n            </th>\r\n            <th>\r\n                Dodatki \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60e0399df5831e759937ee375530afed5729fd387944", async() => {
                WriteLiteral("\r\n                    <span class=\"glyphicon glyphicon-pencil\" aria-hidden=\"true\"> </span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </th>
            <th class=""col-lg-1"">
                24 cm
            </th>
            <th class=""col-lg-1"">
                32 cm
            </th>
            <th class=""col-lg-1"">
                42 cm
            </th>
            <th class=""col-lg-1 ali"">
                Ciasto
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 56 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
         foreach (var item in Model.allPizzas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60e0399df5831e759937ee375530afed5729fd3810165", async() => {
#nullable restore
#line 60 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
                                                                    Write(Html.DisplayFor(modelItem => item.PizzaName));

#line default
#line hidden
#nullable disable
                WriteLiteral("  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
                                              WriteLiteral(item.PizzaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60e0399df5831e759937ee375530afed5729fd3812734", async() => {
                WriteLiteral("\r\n                        <span class=\"glyphicon glyphicon-pencil\" aria-hidden=\"true\" > </span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
                                           WriteLiteral(item.PizzaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60e0399df5831e759937ee375530afed5729fd3815086", async() => {
                WriteLiteral("\r\n                        <span class=\"glyphicon glyphicon-remove-sign\" aria-hidden=\"true\" ></span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
                                             WriteLiteral(item.PizzaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 69 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
                     foreach (var it in Model.allPizzasToppings.Where(x => x.PizzaId == item.PizzaId))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => it.Topping.ToppingName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
                                                                             ; 

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;");
#nullable restore
#line 71 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
                                                                                                   
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PriceSmall));

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PriceMedium));

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PriceBig));

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 84 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dough));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 87 "D:\Studia\II stopien\Technologie dla aplikacji klasy enterprise\Laboratorium\Projekt\PizzeriaApp\PizzeriaApp\Views\Pizza\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzeriaApp.Models.AllDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
