#pragma checksum "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86e0d49e3090e17511bd6a3f949617f4045e9172"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_OwnerApproval_Default), @"mvc.1.0.view", @"/Views/Shared/Components/OwnerApproval/Default.cshtml")]
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
#line 7 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\_ViewImports.cshtml"
using TableReady.Core.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\_ViewImports.cshtml"
using TableReady.Core.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86e0d49e3090e17511bd6a3f949617f4045e9172", @"/Views/Shared/Components/OwnerApproval/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c385e059e264da2a028405a1ef1e89e8c7deb565", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_OwnerApproval_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TableReady.Core.App.Models.OwnerModelView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.OwnerFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.RequestStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.OwnerFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.RequestStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
               Write(Html.ActionLink("Approve", "OwnerApprove", new { id = item.OwnerId }, new { @class = "btn btn-success mx-1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 55 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
               Write(Html.ActionLink("Deny", "OwnerDeny", new { id = item.OwnerId }, new { @class = "btn btn-danger mx-1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 58 "C:\Users\849950\source\repos\TableReady.Core_Final\TableReady.Core.App\Views\Shared\Components\OwnerApproval\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TableReady.Core.App.Models.OwnerModelView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
