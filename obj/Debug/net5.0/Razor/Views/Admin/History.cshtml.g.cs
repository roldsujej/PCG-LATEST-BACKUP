#pragma checksum "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "94d040e695952b8b7e6909b407d00457e0805d1ffaefaa24f0ae79b09f886d4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_History), @"mvc.1.0.view", @"/Views/Admin/History.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"94d040e695952b8b7e6909b407d00457e0805d1ffaefaa24f0ae79b09f886d4a", @"/Views/Admin/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"194cce456bb1ecb3f0b4e04e1a27dcf9c36236045229457aa128b29d50bb1d71", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<pcg.Models.VariationModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
  
    ViewData["Title"] = "History";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card"">
    <div class=""top-card"">
        <h1 >Tasks History</h1>

    </div>
   
    <input class=""input"" name=""text"" id=""search"" type=""text"" placeholder=""Search here..."" onkeyup=""searchTable()"">
 
    <div class=""table-container"">


<table class=""custom-table"">
    <thead>
        <tr>
            <th class=""text-center text-uppercase"">Log No.</th>
            <th class=""text-center text-uppercase"">Task No.</th>
            <th class=""text-center text-uppercase"">Assigned/Forwarded</th>
            <th class=""text-center text-uppercase"">Added By</th>
            <th class=""text-center text-uppercase"">Client/Site</th>
            <th class=""text-center text-uppercase"">Status</th>
            <th class=""text-center text-uppercase"">Date Start</th>
            <th class=""text-center text-uppercase"">Date Forwarded</th>
            <th class=""text-center text-uppercase"">Date Received</th>
            <th class=""text-center text-uppercase"">Date Completed</th>         
        </t");
            WriteLiteral("r>\r\n    </thead>\r\n    <tbody id=\"myTable\" class=\"viewbag-data\">\r\n");
#nullable restore
#line 33 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
         foreach (System.Data.DataRow dr in ViewBag.Tasklog.Rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
           Write(dr["LogId"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
           Write(dr["TaskId"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
           Write(dr["Name"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
           Write(dr["AddedBy"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
           Write(dr["Client"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 40 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
                                    Write(dr["Site"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
           Write(dr["Status"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
           Write(dr["DateStart"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
           Write(dr["DateFwd"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
           Write(dr["DateRcv"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
           Write(dr["DateClr"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n      \r\n        <!-- Pagination -->\r\n");
            WriteLiteral(@"


        <ul class=""pagination modal-1"">
            <li><a href=""#"" class=""prev"" onclick=""prevPage()"">&laquo</a></li>
            <li id=""pageNumbers"">
                <!-- Page numbers will be inserted here -->
            </li>

            <li><a href=""#"" class=""next"" onclick=""nextPage()"">&raquo;</a></li>
        </ul>

        <br>
      

       



    </div>

</div>
<script>
   
</script>


");
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
