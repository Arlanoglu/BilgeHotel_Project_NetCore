#pragma checksum "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\RoomTypesList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "786967795923083ee4c22e69fcc3c2eb17d832eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RoomTypesList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RoomTypesList/Default.cshtml")]
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
#line 1 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.RoomType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.Aboutus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.HotelService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.Reservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.ServicePack;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786967795923083ee4c22e69fcc3c2eb17d832eb", @"/Views/Shared/Components/RoomTypesList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7444a5094449e7b806336027213763bc406a0604", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RoomTypesList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VMRoomTypeName>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 4 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\RoomTypesList\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 92, "\"", 124, 2);
            WriteAttributeValue("", 99, "/Room/RoomDetail/", 99, 17, true);
#nullable restore
#line 6 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\RoomTypesList\Default.cshtml"
WriteAttributeValue("", 116, item.ID, 116, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 6 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\RoomTypesList\Default.cshtml"
                                           Write(item.RoomTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 7 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\RoomTypesList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VMRoomTypeName>> Html { get; private set; }
    }
}
#pragma warning restore 1591
