#pragma checksum "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnMVCUsingModels\HandsOnMVCUsingModels\Views\Student\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aff278e6ac021e9708bbd021e8ea1aa6fd0c954e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
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
#line 1 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnMVCUsingModels\HandsOnMVCUsingModels\Views\_ViewImports.cshtml"
using HandsOnMVCUsingModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnMVCUsingModels\HandsOnMVCUsingModels\Views\_ViewImports.cshtml"
using HandsOnMVCUsingModels.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aff278e6ac021e9708bbd021e8ea1aa6fd0c954e", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2737c80b8a82d20cc8617ce48adabf9015cddf35", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnMVCUsingModels\HandsOnMVCUsingModels\Views\Student\Details.cshtml"
  
	Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aff278e6ac021e9708bbd021e8ea1aa6fd0c954e4053", async() => {
                WriteLiteral("\r\n\t<meta name=\"viewport\" content=\"width=device-width\" />\r\n\t<title>Details</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aff278e6ac021e9708bbd021e8ea1aa6fd0c954e5110", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnMVCUsingModels\HandsOnMVCUsingModels\Views\Student\Details.cshtml"
      
		if (Model != null)
		{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<h2>Student Details</h2>\r\n\t\t\t<pre>\r\nID:");
#nullable restore
#line 20 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnMVCUsingModels\HandsOnMVCUsingModels\Views\Student\Details.cshtml"
Write(Model.Sid);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\nName:");
#nullable restore
#line 21 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnMVCUsingModels\HandsOnMVCUsingModels\Views\Student\Details.cshtml"
Write(Model.Sname);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\nAge:");
#nullable restore
#line 22 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnMVCUsingModels\HandsOnMVCUsingModels\Views\Student\Details.cshtml"
Write(Model.Age);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n</pre>\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aff278e6ac021e9708bbd021e8ea1aa6fd0c954e6491", async() => {
                    WriteLiteral("back");
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
                WriteLiteral("\r\n");
#nullable restore
#line 25 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnMVCUsingModels\HandsOnMVCUsingModels\Views\Student\Details.cshtml"
		}
		else
		{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<h2>Invlid Student ID</h2>\r\n");
#nullable restore
#line 29 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnMVCUsingModels\HandsOnMVCUsingModels\Views\Student\Details.cshtml"
		}
	

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
