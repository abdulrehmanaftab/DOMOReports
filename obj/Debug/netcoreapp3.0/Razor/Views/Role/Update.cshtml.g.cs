#pragma checksum "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4448a4dc63f894c8cfe19bee65dc6fe73039da87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Update), @"mvc.1.0.view", @"/Views/Role/Update.cshtml")]
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
#line 1 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
using ProgrammaticFiltering.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4448a4dc63f894c8cfe19bee65dc6fe73039da87", @"/Views/Role/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf6701f525db7eaedfe7b0b67bb0b2ca7f5d4bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleEdit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
  
    ViewData["Page"] = "Roles";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Edit Role</h4>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4448a4dc63f894c8cfe19bee65dc6fe73039da875025", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4448a4dc63f894c8cfe19bee65dc6fe73039da876261", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 8 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4448a4dc63f894c8cfe19bee65dc6fe73039da877858", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-3\">\r\n            <input type=\"hidden\" name=\"roleName\"");
                BeginWriteAttribute("value", " value=\"", 358, "\"", 382, 1);
#nullable restore
#line 13 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
WriteAttributeValue("", 366, Model.Role.Name, 366, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"roleId\"");
                BeginWriteAttribute("value", " value=\"", 434, "\"", 456, 1);
#nullable restore
#line 14 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
WriteAttributeValue("", 442, Model.Role.Id, 442, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            <h5>Add To ");
#nullable restore
#line 16 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                  Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <table class=\"table table-bordered table-sm\">\r\n");
#nullable restore
#line 18 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                 if (Model.NonMembers.Count() == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr><td colspan=\"2\">All Users Are Members</td></tr>\r\n");
#nullable restore
#line 21 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                     foreach (ApplicationUser user in Model.NonMembers)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 27 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                           Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>\r\n                                <input type=\"checkbox\" name=\"AddIds\"");
                BeginWriteAttribute("value", " value=\"", 1059, "\"", 1075, 1);
#nullable restore
#line 29 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
WriteAttributeValue("", 1067, user.Id, 1067, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 32 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n\r\n            <h5>Remove From ");
#nullable restore
#line 36 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                       Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <table class=\"table table-bordered table-sm\" style=\"width:25%;\">\r\n");
#nullable restore
#line 38 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                 if (Model.Members.Count() == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr><td colspan=\"2\">No Users Are Members</td></tr>\r\n");
#nullable restore
#line 41 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                }
                else
                {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                         foreach (ApplicationUser user in Model.Members)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 47 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                           Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>\r\n                                <input type=\"checkbox\" name=\"DeleteIds\"");
                BeginWriteAttribute("value", " value=\"", 1830, "\"", 1846, 1);
#nullable restore
#line 49 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
WriteAttributeValue("", 1838, user.Id, 1838, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 52 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\ali-work\Team Lead\Condado\Projects\DOMO-SSO\Views\Role\Update.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleEdit> Html { get; private set; }
    }
}
#pragma warning restore 1591