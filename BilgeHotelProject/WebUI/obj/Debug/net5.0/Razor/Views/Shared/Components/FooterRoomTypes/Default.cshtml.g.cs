#pragma checksum "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterRoomTypes\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dea6bb179947b52a94ab3a93ed05efb9799874b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FooterRoomTypes_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FooterRoomTypes/Default.cshtml")]
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
#nullable restore
#line 9 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using Core.Utilities.Results.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea6bb179947b52a94ab3a93ed05efb9799874b2", @"/Views/Shared/Components/FooterRoomTypes/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b316f31f2b8a8ce08b312311e2109279b4403493", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FooterRoomTypes_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VMRoomTypeName>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterRoomTypes\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n        <li><i class=\"bx bx-chevron-right\"></i> <a");
            BeginWriteAttribute("href", " href=\"", 124, "\"", 156, 2);
            WriteAttributeValue("", 131, "/Room/RoomDetail/", 131, 17, true);
#nullable restore
#line 6 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterRoomTypes\Default.cshtml"
WriteAttributeValue("", 148, item.ID, 148, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 6 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterRoomTypes\Default.cshtml"
                                                                               Write(item.RoomTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n    </ul>\r\n");
#nullable restore
#line 8 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterRoomTypes\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VMRoomTypeName>> Html { get; private set; }
    }
}
#pragma warning restore 1591
