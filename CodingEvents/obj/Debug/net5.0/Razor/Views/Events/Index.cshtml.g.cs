#pragma checksum "C:\Users\Mia\Desktop\LaunchCode_Microsoft\csharp-practice\bluephoenix5\ASP.NET\ASP.NET-Chp13-14 Walkthrough\CodingEvents\Views\Events\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a9220763e4c3ad0bc1aa159552f4f9ccd46de26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Index), @"mvc.1.0.view", @"/Views/Events/Index.cshtml")]
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
#line 1 "C:\Users\Mia\Desktop\LaunchCode_Microsoft\csharp-practice\bluephoenix5\ASP.NET\ASP.NET-Chp13-14 Walkthrough\CodingEvents\Views\_ViewImports.cshtml"
using CodingEvents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mia\Desktop\LaunchCode_Microsoft\csharp-practice\bluephoenix5\ASP.NET\ASP.NET-Chp13-14 Walkthrough\CodingEvents\Views\_ViewImports.cshtml"
using CodingEvents.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mia\Desktop\LaunchCode_Microsoft\csharp-practice\bluephoenix5\ASP.NET\ASP.NET-Chp13-14 Walkthrough\CodingEvents\Views\Events\Index.cshtml"
using CodingEventsDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a9220763e4c3ad0bc1aa159552f4f9ccd46de26", @"/Views/Events/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2964dd59c32e4df324b99d9423fb70affcb2b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Events", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>Coding Events</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a9220763e4c3ad0bc1aa159552f4f9ccd46de264519", async() => {
                WriteLiteral("Add Event");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a9220763e4c3ad0bc1aa159552f4f9ccd46de265906", async() => {
                WriteLiteral("Delete Event");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Mia\Desktop\LaunchCode_Microsoft\csharp-practice\bluephoenix5\ASP.NET\ASP.NET-Chp13-14 Walkthrough\CodingEvents\Views\Events\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No events yet!</p>\r\n");
#nullable restore
#line 20 "C:\Users\Mia\Desktop\LaunchCode_Microsoft\csharp-practice\bluephoenix5\ASP.NET\ASP.NET-Chp13-14 Walkthrough\CodingEvents\Views\Events\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>Name</th>\r\n            <th>Description</th>\r\n    </tr>\r\n    \r\n");
#nullable restore
#line 30 "C:\Users\Mia\Desktop\LaunchCode_Microsoft\csharp-practice\bluephoenix5\ASP.NET\ASP.NET-Chp13-14 Walkthrough\CodingEvents\Views\Events\Index.cshtml"
     foreach (var evt in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Mia\Desktop\LaunchCode_Microsoft\csharp-practice\bluephoenix5\ASP.NET\ASP.NET-Chp13-14 Walkthrough\CodingEvents\Views\Events\Index.cshtml"
           Write(evt.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Mia\Desktop\LaunchCode_Microsoft\csharp-practice\bluephoenix5\ASP.NET\ASP.NET-Chp13-14 Walkthrough\CodingEvents\Views\Events\Index.cshtml"
           Write(evt.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\Mia\Desktop\LaunchCode_Microsoft\csharp-practice\bluephoenix5\ASP.NET\ASP.NET-Chp13-14 Walkthrough\CodingEvents\Views\Events\Index.cshtml"
           Write(evt.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Mia\Desktop\LaunchCode_Microsoft\csharp-practice\bluephoenix5\ASP.NET\ASP.NET-Chp13-14 Walkthrough\CodingEvents\Views\Events\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 39 "C:\Users\Mia\Desktop\LaunchCode_Microsoft\csharp-practice\bluephoenix5\ASP.NET\ASP.NET-Chp13-14 Walkthrough\CodingEvents\Views\Events\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
