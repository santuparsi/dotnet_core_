#pragma checksum "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aecac5570dcb4c6c2b1c8b3bafb2233b313a9e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
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
#line 1 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\_ViewImports.cshtml"
using HandsOnHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\_ViewImports.cshtml"
using HandsOnHelpers.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aecac5570dcb4c6c2b1c8b3bafb2233b313a9e6", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c7cf71790263c6dc52cd7ff3dacb6027c93547a", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\User\Login.cshtml"
  
	Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aecac5570dcb4c6c2b1c8b3bafb2233b313a9e63521", async() => {
                WriteLiteral("\r\n\t<meta name=\"viewport\" content=\"width=device-width\" />\r\n\t<title>Create</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aecac5570dcb4c6c2b1c8b3bafb2233b313a9e64577", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\User\Login.cshtml"
     using (Html.BeginForm("Register", "User"))
	{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t<table border=\"1\">\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Name</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 18 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\User\Login.cshtml"
               Write(Html.TextBox("Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Gender</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\tMale ");
#nullable restore
#line 23 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\User\Login.cshtml"
                    Write(Html.RadioButton("Gender", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\tFemale ");
#nullable restore
#line 24 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\User\Login.cshtml"
                      Write(Html.RadioButton("Gender", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>DOB</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 29 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\User\Login.cshtml"
               Write(Html.TextBox("DOB", null, new { type = "date" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Email</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 33 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\User\Login.cshtml"
               Write(Html.TextBox("Email"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>MobileNo</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 37 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\User\Login.cshtml"
               Write(Html.TextBox("Mobile"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Country</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 41 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\User\Login.cshtml"
               Write(Html.DropDownList("Country", new SelectList(new string[] { "Indai", "US", "UK", "Japan" })));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Password</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 45 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\User\Login.cshtml"
               Write(Html.Password("Pwd"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td colspan=\"2\">\r\n\t\t\t\t\t");
#nullable restore
#line 49 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\User\Login.cshtml"
               Write(Html.CheckBox("flag"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" Accpet all terms and conditions\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td colspan=\"2\">\r\n\t\t\t\t\t<input type=\"submit\" value=\"Register\" />\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n\t\t</table>\r\n");
#nullable restore
#line 58 "D:\Batch6(02.08.2021)\dotnet_core_\Module3\MVC\HandsOnHelpers\HandsOnHelpers\Views\User\Login.cshtml"
	}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
