#pragma checksum "D:\OneDrive\Projects\02. SoftUni - Tehnology Fundamentals with C#\30. BASIC WEB\WebAspApp\WebAspApp\Views\Home\Numbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847bbe515619582e1a6e22a8763be4d76646c57d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Numbers), @"mvc.1.0.view", @"/Views/Home/Numbers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Numbers.cshtml", typeof(AspNetCore.Views_Home_Numbers))]
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
#line 1 "D:\OneDrive\Projects\02. SoftUni - Tehnology Fundamentals with C#\30. BASIC WEB\WebAspApp\WebAspApp\Views\_ViewImports.cshtml"
using WebAspApp;

#line default
#line hidden
#line 2 "D:\OneDrive\Projects\02. SoftUni - Tehnology Fundamentals with C#\30. BASIC WEB\WebAspApp\WebAspApp\Views\_ViewImports.cshtml"
using WebAspApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847bbe515619582e1a6e22a8763be4d76646c57d", @"/Views/Home/Numbers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"043d7025dc303a41886e88f80df3aa6989e8433e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Numbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\OneDrive\Projects\02. SoftUni - Tehnology Fundamentals with C#\30. BASIC WEB\WebAspApp\WebAspApp\Views\Home\Numbers.cshtml"
  
    ViewBag.NNN = "Nums 1 .. " + ViewBag.jkl;

#line default
#line hidden
            BeginContext(56, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(63, 11, false);
#line 6 "D:\OneDrive\Projects\02. SoftUni - Tehnology Fundamentals with C#\30. BASIC WEB\WebAspApp\WebAspApp\Views\Home\Numbers.cshtml"
Write(ViewBag.NNN);

#line default
#line hidden
            EndContext();
            BeginContext(74, 13, true);
            WriteLiteral("</h2>\r\n<ul>\r\n");
            EndContext();
#line 8 "D:\OneDrive\Projects\02. SoftUni - Tehnology Fundamentals with C#\30. BASIC WEB\WebAspApp\WebAspApp\Views\Home\Numbers.cshtml"
     for (int i = 1; i <= ViewBag.jkl; i++)
    {

#line default
#line hidden
            BeginContext(139, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(152, 1, false);
#line 10 "D:\OneDrive\Projects\02. SoftUni - Tehnology Fundamentals with C#\30. BASIC WEB\WebAspApp\WebAspApp\Views\Home\Numbers.cshtml"
       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(153, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "D:\OneDrive\Projects\02. SoftUni - Tehnology Fundamentals with C#\30. BASIC WEB\WebAspApp\WebAspApp\Views\Home\Numbers.cshtml"
    }

#line default
#line hidden
            BeginContext(167, 37, true);
            WriteLiteral("</ul>\r\n<h1></h1>\r\n<li>gljjhl</li>\r\n\r\n");
            EndContext();
            BeginContext(204, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c55aa507baa449c2ac2f9e8a05decc3f", async() => {
                BeginContext(224, 103, true);
                WriteLiteral("\r\n    <input type=\"text\" placeholder=\"New numnum\" name=\"PichMich\" />\r\n    <input type=\"submit\" />    \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(334, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
