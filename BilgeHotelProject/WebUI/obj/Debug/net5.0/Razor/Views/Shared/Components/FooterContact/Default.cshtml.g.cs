#pragma checksum "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterContact\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0375768443c0bf1c9bf30337047da3ba90b046c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FooterContact_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FooterContact/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0375768443c0bf1c9bf30337047da3ba90b046c1", @"/Views/Shared/Components/FooterContact/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1321f05d455997e00aa298db0b8db471fe43665b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FooterContact_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VMContact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterContact\Default.cshtml"
  
    if (Model.Adress != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 6 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterContact\Default.cshtml"
      Write(Model.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterContact\Default.cshtml"
    }
    if (Model.Phone1 != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>Phone:</strong> ");
#nullable restore
#line 10 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterContact\Default.cshtml"
                           Write(Model.Phone1);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\r\n");
#nullable restore
#line 12 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterContact\Default.cshtml"
    }
    if (Model.Phone2 != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>Phone:</strong> ");
#nullable restore
#line 15 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterContact\Default.cshtml"
                           Write(Model.Phone2);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\r\n");
#nullable restore
#line 17 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterContact\Default.cshtml"
    }
    if (Model.Fax != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>Phone:</strong> ");
#nullable restore
#line 20 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterContact\Default.cshtml"
                           Write(Model.Fax);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\r\n");
#nullable restore
#line 22 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterContact\Default.cshtml"
    }
    if (Model.Email != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>Email:</strong> ");
#nullable restore
#line 25 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterContact\Default.cshtml"
                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\r\n");
#nullable restore
#line 27 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Shared\Components\FooterContact\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VMContact> Html { get; private set; }
    }
}
#pragma warning restore 1591
