#pragma checksum "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca3549e633a82df06554cfaf593b9d46dd94817b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RPG.Pages.Pages_Location), @"mvc.1.0.razor-page", @"/Pages/Location.cshtml")]
namespace RPG.Pages
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
#line 1 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\_ViewImports.cshtml"
using RPG;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
using RPG.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca3549e633a82df06554cfaf593b9d46dd94817b", @"/Pages/Location.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f55bdca3dc11af8930e175bf7ae226956281f648", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Location : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/location", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "SearchFood", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Sleep", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
  
    ViewData["Title"] = "Location";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n");
#nullable restore
#line 9 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
         if (Model.location.Achievement != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Získán nový úspěch - ");
#nullable restore
#line 11 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
                               Write(Model.location.Achievement.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 11 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
                                                                 Write(Model.location.Achievement.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n            <hr />\r\n");
#nullable restore
#line 13 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        <h1 class=\"display-4\">");
#nullable restore
#line 17 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
                         Write(Model.location.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p>");
#nullable restore
#line 18 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
      Write(Model.location.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <hr />\r\n\r\n");
#nullable restore
#line 22 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
         foreach (var path in Model.location.Paths)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca3549e633a82df06554cfaf593b9d46dd94817b6378", async() => {
#nullable restore
#line 24 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
                                                                        Write(path.Description);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-path", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
                                           WriteLiteral(path.NextLocationId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["path"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-path", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["path"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 25 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
         if (Model.location.CanSearchFood)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca3549e633a82df06554cfaf593b9d46dd94817b9328", async() => {
                WriteLiteral("Hledat jídlo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 30 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
         if (Model.location.CanSleep)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca3549e633a82df06554cfaf593b9d46dd94817b11171", async() => {
                WriteLiteral("Vyspat se");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 34 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <hr />\r\n\r\n");
#nullable restore
#line 38 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
         if (Model.location.ShowStats)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Tvé statistiky:</h2>\r\n            <p>Jídlo: ");
#nullable restore
#line 41 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
                 Write(Model.Stats.Food);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</p>\r\n            <p>Energie: ");
#nullable restore
#line 42 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
                   Write(Model.Stats.Energy);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</p>\r\n");
#nullable restore
#line 43 "C:\Users\miken\Source\Repos\2019p2prg-adventure-rpg-game-bukvic-mikenda\RPG\RPG\Pages\Location.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RPG.Pages.LocationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RPG.Pages.LocationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RPG.Pages.LocationModel>)PageContext?.ViewData;
        public RPG.Pages.LocationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
