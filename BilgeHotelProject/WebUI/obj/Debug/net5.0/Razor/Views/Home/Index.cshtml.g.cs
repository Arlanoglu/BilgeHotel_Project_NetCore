#pragma checksum "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b16f885bcb3fd7f174da8f9f938ed41f4d4c579a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
using WebUI.Models.Employee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.RoomFacility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using Core.Utilities.Results.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.ExtraService;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b16f885bcb3fd7f174da8f9f938ed41f4d4c579a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bdc80939dcb56c3c36ddde664ffd6bc83e82d0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VMHomeIndex>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Ana Sayfa";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--<!-- ======= Carousel ======= -->
<div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"">
");
#nullable restore
#line 14 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
          
            int number = 1;
            if (Model.VMHomePage.VMHomePageSlide.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                 foreach (var item in Model.VMHomePage.VMHomePageSlide)
                {

                    if (number == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item active\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 884, "\"", 906, 1);
#nullable restore
#line 24 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 890, item.PictureUrl, 890, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\"");
            BeginWriteAttribute("alt", " alt=\"", 929, "\"", 952, 1);
#nullable restore
#line 24 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 935, item.PictureName, 935, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n");
#nullable restore
#line 26 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1145, "\"", 1167, 1);
#nullable restore
#line 30 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1151, item.PictureUrl, 1151, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\"");
            BeginWriteAttribute("alt", " alt=\"", 1190, "\"", 1213, 1);
#nullable restore
#line 30 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1196, item.PictureName, 1196, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n");
#nullable restore
#line 32 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                    }
                    number++;
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                 
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>
<!-- End Carousel -->

<main id=""main"">

    <!-- ======= About Us Section ======= -->
    <section id=""about-us"" class=""about-us"">
        <div class=""container"" data-aos=""fade-up"">

            <div class=""section-title"">
");
#nullable restore
#line 57 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                  
                    if (Model.VMHomePage.Title != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2><strong>");
#nullable restore
#line 60 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                               Write(Model.VMHomePage.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h2>\r\n");
#nullable restore
#line 61 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            \r\n            <div class=\"row content\">\r\n                <div class=\"col-lg-6\" data-aos=\"fade-right\">\r\n");
#nullable restore
#line 67 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                      
                        if (Model.VMHomePage.PictureUrl != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 2578, "\"", 2612, 1);
#nullable restore
#line 70 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2584, Model.VMHomePage.PictureUrl, 2584, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n");
#nullable restore
#line 71 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"col-lg-6 pt-4 pt-lg-0\" data-aos=\"fade-left\">\r\n");
#nullable restore
#line 75 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                      
                        if (Model.VMHomePage.Title != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h4 class=\"font-italic\">Bilge Hotel\'e Hoşgeldiniz...</h4>\r\n");
#nullable restore
#line 79 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                        }
                        if (Model.VMHomePage.Paragraph1 != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 82 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                          Write(Model.VMHomePage.Paragraph1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 83 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                        }
                        if (Model.VMHomePage.Paragraph2 != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 86 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                          Write(Model.VMHomePage.Paragraph2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 87 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                        }
                        if (Model.VMHomePage.Paragraph3 != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 90 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                          Write(Model.VMHomePage.Paragraph3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 91 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                        }
                        if (Model.VMHomePage.Paragraph4 != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 94 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                          Write(Model.VMHomePage.Paragraph4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 95 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                        }
                        if (Model.VMHomePage.Paragraph5 != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 98 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                          Write(Model.VMHomePage.Paragraph5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 99 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>

        </div>
    </section><!-- End About Us Section -->
    <!-- ======= Portfolio Section ======= -->
    <section id=""rooms-sec"" class=""rooms-sec"">
        <div class=""container"">

            <div class=""section-title"" data-aos=""fade-up"">
                <h2>Odalarımız</h2>
            </div>


            <div class=""row pt-35"">
");
#nullable restore
#line 116 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                 if (Model.VMRoomTypes.Count>0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                     foreach (var item in Model.VMRoomTypes)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 col-md-6\">\r\n                            <div class=\"room-card\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4649, "\"", 4681, 2);
            WriteAttributeValue("", 4656, "/Room/RoomDetail/", 4656, 17, true);
#nullable restore
#line 122 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 4673, item.ID, 4673, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 123 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                                     if (item.VMRoomPictures.Count > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img style=\"height:14rem\"");
            BeginWriteAttribute("src", " src=\"", 4862, "\"", 4916, 1);
#nullable restore
#line 125 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 4868, item.VMRoomPictures.FirstOrDefault().PictureUrl, 4868, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Images\" class=\"img-fluid\">\r\n");
#nullable restore
#line 126 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img style=\"height:14rem\" src=\"https://www.natro.com/hosting-sozlugu/wp-content/uploads/2015/12/404-not-found.png\" alt=\"Images\" class=\"img-fluid\">\r\n");
#nullable restore
#line 130 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </a>\r\n                                <div class=\"content\">\r\n                                    <h3><a");
            BeginWriteAttribute("href", " href=\"", 5433, "\"", 5465, 2);
            WriteAttributeValue("", 5440, "/Room/RoomDetail/", 5440, 17, true);
#nullable restore
#line 133 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 5457, item.ID, 5457, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 133 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                                                                       Write(item.RoomTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                    <ul>\r\n                                        <li>");
#nullable restore
#line 135 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                                       Write(item.Price.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li>Gecelik</li>\r\n                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 141 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>


        </div>
    </section><!-- End Portfolio Section -->

</main><!-- End #main -->
<!-- Footer-Section -->
<!--<div class=""hom-footer-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-3 col-4 px-md-2 px-1"">
                <label class=""col-form-label"" for=""start"">Giriş Tarihi</label>
                <input class=""form-control"" type=""date"" id=""checkinDate"" name=""trip-start"" value="""">
            </div>
            <div class=""col-md-3 col-4 px-md-2 px-1"">
                <label class=""col-form-label"" for=""start"">Çıkış Tarihi</label>
                <input class=""form-control"" type=""date"" id=""checkoutDate"" name=""trip-start"" value="""">
            </div>
            <div class=""col-md-3 col-4 px-md-2 px-1"">
                <label class=""col-form-label"" for=""start"">Kişi Sayısı</label>
                <input class=""form-control"" type=""number"" id=""start"" name=""trip-start"" value=""1"" min=""1"" max=""4"">
            </div>
      ");
            WriteLiteral(@"      <div class=""col-md-3 col-12 px-md-2"">
                <label class=""col-form-label"" for=""start""><br /></label>
                <a class=""btn btn-danger form-control"" href=""booking.html"">Odaları Listele</a>
            </div>
        </div>
    </div>
</div>--><!-- End-Footer-Section -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VMHomeIndex> Html { get; private set; }
    }
}
#pragma warning restore 1591
