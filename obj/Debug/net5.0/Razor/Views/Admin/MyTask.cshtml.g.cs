#pragma checksum "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4f0dd9a157504c701f344f3040c9459bbef57f7676d0ad0526dead3e2f7d6288"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_MyTask), @"mvc.1.0.view", @"/Views/Admin/MyTask.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\_ViewImports.cshtml"
using pcg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\_ViewImports.cshtml"
using pcg.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4f0dd9a157504c701f344f3040c9459bbef57f7676d0ad0526dead3e2f7d6288", @"/Views/Admin/MyTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"194cce456bb1ecb3f0b4e04e1a27dcf9c36236045229457aa128b29d50bb1d71", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_MyTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<pcg.Models.VariationModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TaskForward", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
  
    ViewData["Title"] = "My Task";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!-- Modal Structure -->\r\n");
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n    <div class=\"top-card\">\r\n        <h1>My Tasks</h1>\r\n\r\n    </div>\r\n\r\n    <input class=\"input\" name=\"text\" id=\"search\" type=\"text\" placeholder=\"Search here...\" onkeyup=\"searchTable()\">\r\n");
#nullable restore
#line 68 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
     if (ViewBag.Tasklog.Rows.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"empty-table-message\">\r\n            <p>No tasks entry...</p>\r\n        </div>\r\n");
#nullable restore
#line 73 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-container"">
        <table id=""custom-table"" class=""custom-table"">

            <thead>
                <tr>
                    <th>Task No.</th>
                    <th>Task</th>
                    <th>Remarks</th>
                    <th>Description</th>
                    <th>Client</th>
                    <th>Added By</th>
                    <th>Date Forwarded</th>
                    <th>Date Received</th>
                    <th>Assignee</th>
                    <th>Name</th>

                </tr>
            </thead>
            <tbody id=""myTable"">
");
#nullable restore
#line 95 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
                 foreach (System.Data.DataRow dr in ViewBag.Tasklog.Rows)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr onclick=\"toggleRows(this)\">\r\n                        <td class=\"text-center text-nowrap\">");
#nullable restore
#line 98 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
                                                       Write(dr["TaskID_Tasks"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center text-nowrap\">");
#nullable restore
#line 99 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
                                                       Write(dr["Task"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center text-nowrap\">");
#nullable restore
#line 100 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
                                                       Write(dr["Remarks"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center text-nowrap\">");
#nullable restore
#line 101 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
                                                       Write(dr["Description"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center text-nowrap\">");
#nullable restore
#line 102 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
                                                       Write(dr["Client"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 102 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
                                                                                Write(dr["Site"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center text-nowrap\">");
#nullable restore
#line 103 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
                                                       Write(dr["AddedBy"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center text-nowrap\">");
#nullable restore
#line 104 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
                                                       Write(dr["DateFwd"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center text-nowrap\">");
#nullable restore
#line 105 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
                                                       Write(dr["DateRcv"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center text-nowrap\">");
#nullable restore
#line 106 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
                                                       Write(dr["Name"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f0dd9a157504c701f344f3040c9459bbef57f7676d0ad0526dead3e2f7d62889491", async() => {
                WriteLiteral("Forward");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-taskId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
                                                                                          WriteLiteral(dr["TaskID_Tasks"].ToString());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["taskId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-taskId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["taskId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            \r\n");
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 127 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>

        </table>
    </div>
        <ul class=""pagination modal-1"">
            <li><a href=""#"" class=""prev"" onclick=""prevPage()"">&laquo</a></li>
            <li id=""pageNumbers"">
                <!-- Page numbers will be inserted here -->
            </li>

            <li><a href=""#"" class=""next"" onclick=""nextPage()"">&raquo;</a></li>
        </ul>
");
            WriteLiteral("        <br>\r\n");
#nullable restore
#line 142 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\MyTask.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<pcg.Models.VariationModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
