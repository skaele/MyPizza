#pragma checksum "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c9afe3a3902336f9f469f1c2db6bc3db3b92d08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dishes_ConcreteDish), @"mvc.1.0.view", @"/Views/Dishes/ConcreteDish.cshtml")]
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
#line 1 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\_ViewImports.cshtml"
using MyPizza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\_ViewImports.cshtml"
using MyPizza.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\_ViewImports.cshtml"
using MyPizza.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\_ViewImports.cshtml"
using MyPizza.Abstractions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c9afe3a3902336f9f469f1c2db6bc3db3b92d08", @"/Views/Dishes/ConcreteDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed6673676eb67be3bd3c9d9bc8214358d9aef57d", @"/Views/_ViewImports.cshtml")]
    public class Views_Dishes_ConcreteDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form_radio"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
  
    string modelType = Model.GetType().ToString().Split(".").Last();
    string dishImagePath = Url.Content("~/img/{modelType}/{Model.ImageId}.png");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n    <div class=\"concrete_dish\" >\n        <div class=\"row\">\n            <div class=\"col-5 img_box\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 310, "\"", 330, 1);
#nullable restore
#line 10 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
WriteAttributeValue("", 316, dishImagePath, 316, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 331, "\"", 347, 1);
#nullable restore
#line 10 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
WriteAttributeValue("", 337, modelType, 337, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img_box_main_img\">\n            </div>\n            <div class=\"col-7 main_content\">\n                <div class=\"desc\">\n                    <h2 class=\"desc_head\">");
#nullable restore
#line 14 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <div class=\"desc_main\">");
#nullable restore
#line 15 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                </div>\n                <div class=\"dish_info\">\n                    <h3 class=\"dish_info_head\">Состав:</h3>\n                    <div class=\"dish_info_content\">");
#nullable restore
#line 19 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
                                              Write(Model.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                </div>\n");
#nullable restore
#line 21 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
                 if(modelType == "Pizza")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"dish_info\">\n                    <h3 class=\"dish_info_head\">Энергетическая ценность на 100 гр:</h3>\n                    <div class=\"dish_info_content\">");
#nullable restore
#line 25 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
                                              Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("*10</div>\n                </div>\n");
#nullable restore
#line 27 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"order\">\n                    <h2 class=\"order_head\">Выберите размер: </h2>\n                    <div class=\"choose_size\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c9afe3a3902336f9f469f1c2db6bc3db3b92d087383", async() => {
                WriteLiteral("\n");
#nullable restore
#line 32 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
                               
                                int index = 0;
                                foreach (var size in ViewBag.DishSizes)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"form_radio_btn\">\n                                        <input");
                BeginWriteAttribute("id", " id=\"", 1608, "\"", 1645, 3);
                WriteAttributeValue("", 1613, "radio-", 1613, 6, true);
#nullable restore
#line 37 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
WriteAttributeValue("", 1619, Model.Id.ToString(), 1619, 20, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
WriteAttributeValue("", 1639, index, 1639, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\" name=\"size\"");
                BeginWriteAttribute("value", " value=\"", 1671, "\"", 1684, 1);
#nullable restore
#line 37 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
WriteAttributeValue("", 1679, size, 1679, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                        <label");
                BeginWriteAttribute("for", " for=\"", 1733, "\"", 1771, 3);
                WriteAttributeValue("", 1739, "radio-", 1739, 6, true);
#nullable restore
#line 38 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
WriteAttributeValue("", 1745, Model.Id.ToString(), 1745, 20, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
WriteAttributeValue("", 1765, index, 1765, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
                                                                                 Write(size);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                                    </div>\n");
#nullable restore
#line 40 "C:\Users\skael\source\repos\MyPizza\MyPizza\Views\Dishes\ConcreteDish.cshtml"
                                    index++;
                                }
                              

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <button class=\"to_basket_btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2026, "\"", 2036, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            <i class=\"fas fa-shopping-basket\"></i>\n                        </button>\n                    </div>  \n                </div>              \n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
