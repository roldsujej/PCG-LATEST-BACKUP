#pragma checksum "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\User\TaskDetail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c53091fc80b249a2f2f190d4b579a3adc08b1370ca2b917d9bb1def86927b5b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_TaskDetail), @"mvc.1.0.view", @"/Views/User/TaskDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c53091fc80b249a2f2f190d4b579a3adc08b1370ca2b917d9bb1def86927b5b2", @"/Views/User/TaskDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"194cce456bb1ecb3f0b4e04e1a27dcf9c36236045229457aa128b29d50bb1d71", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_TaskDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<pcg.Models.VariationModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\User\TaskDetail.cshtml"
  
    ViewData["Title"] = "Task Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align:center"">Task Details</h1>
<table class=""table table-hover table-responsive-sm table-sm"">
    <thead>
        <tr>
            <th class=""text-center text-uppercase"">Task No.</th>
            <th class=""text-center text-uppercase"">Task</th>
            <th class=""text-center text-uppercase"">Remarks</th> 
            <th class=""text-center text-uppercase"">Description</th>
            <th class=""text-center text-uppercase"">Added By</th>
            <th class=""text-center text-uppercase"">Date Forwarded</th>
            <th class=""text-center text-uppercase"">Date Received</th>
            <th class=""text-center text-uppercase"">Assigned To</th>
            <th class=""text-center text-uppercase"">Status</th>
        </tr>
    </thead>
    <tbody id=""myTable"">
");
#nullable restore
#line 23 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\User\TaskDetail.cshtml"
         foreach (System.Data.DataRow dr in ViewBag.Tasklog.Rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"text-center text-nowrap\">");
#nullable restore
#line 26 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\User\TaskDetail.cshtml"
                                               Write(dr["TaskID_Tasks"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center text-nowrap\">");
#nullable restore
#line 27 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\User\TaskDetail.cshtml"
                                               Write(dr["Task"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center text-nowrap\">");
#nullable restore
#line 28 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\User\TaskDetail.cshtml"
                                               Write(dr["Remarks"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center text-nowrap\">");
#nullable restore
#line 29 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\User\TaskDetail.cshtml"
                                               Write(dr["Description"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center text-nowrap\">");
#nullable restore
#line 30 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\User\TaskDetail.cshtml"
                                               Write(dr["AddedBy"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center text-nowrap\">");
#nullable restore
#line 31 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\User\TaskDetail.cshtml"
                                               Write(dr["DateFwd"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center text-nowrap\">");
#nullable restore
#line 32 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\User\TaskDetail.cshtml"
                                               Write(dr["DateRcv"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center text-nowrap\">");
#nullable restore
#line 33 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\User\TaskDetail.cshtml"
                                               Write(dr["Name"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>In Progress</td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\User\TaskDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
