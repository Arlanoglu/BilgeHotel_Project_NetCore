#pragma checksum "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8eb36c331296fb6ebd095c789b57cc4650c0076"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_MyReservations), @"mvc.1.0.view", @"/Views/Account/MyReservations.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8eb36c331296fb6ebd095c789b57cc4650c0076", @"/Views/Account/MyReservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42606922065b8970b630106fc7af83d4aa636f45", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_MyReservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VMMyReservation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:18rem; height:18rem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Bilge Hotel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
  
    ViewData["Title"] = "MyReservations";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"contact\" class=\"contact mt-5\">\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 9 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
         if (TempData["CancelReservationResult"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row justify-content-center mt-4\">\r\n                <div class=\"col-12 d-flex justify-content-center bg-warning\">\r\n                    <h5>");
#nullable restore
#line 13 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                   Write(TempData["CancelReservationResult"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 16 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
         if (Model != null && Model.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
             for (int i = Model.Count - 1; i >= 0; i--)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row justify-content-center mt-4"">
                    <div class=""col-12 php-email-form"">

                        <div class=""row"">
                            <div class=""col-md-2 col-12 d-flex justify-content-center"">
                                <div class=""row mb-4 mb-md-0"">
                                    <div class=""col-12 d-flex justify-content-center"">
                                        <b class=""text-danger"">Rezerv. No.</b>
                                    </div>
                                    <div class=""col-12 d-flex justify-content-center"">
                                        <span class=""text-danger"">BLGHTL-");
#nullable restore
#line 32 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                                                    Write(Model[i].ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-10"">
                                <div class=""row"">
                                    <div class=""col-4"">
                                        <div class=""row"">
                                            <div class=""col-12"">
                                                <b>İsim</b>
                                            </div>
                                            <div class=""col-12"">
                                                ");
#nullable restore
#line 44 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                           Write(Model[i].FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                                               Write(Model[i].LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-4"">
                                        <div class=""row"">
                                            <div class=""col-12"">
                                                <b>Rzrv. Tarihi</b>
                                            </div>
                                            <div class=""col-12"">
                                                ");
#nullable restore
#line 54 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                           Write(Model[i].ReservationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-4"">
                                        <div class=""row"">
                                            <div class=""col-12"">
                                                <b>Oda Tipi</b>
                                            </div>
                                            <div class=""col-12"">
                                                ");
#nullable restore
#line 64 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                           Write(Model[i].VMRoomTypeName.RoomTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-12"">
                                        <hr />
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-4"">
                                        <div class=""row"">
                                            <div class=""col-12"">
                                                <b>Giriş Tarihi</b>
                                            </div>
                                            <div class=""col-12"">
                                                ");
#nullable restore
#line 79 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                           Write(Model[i].CheckInDate.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-4"">
                                        <div class=""row"">
                                            <div class=""col-12"">
                                                <b>Çıkış Tarihi</b>
                                            </div>
                                            <div class=""col-12"">
                                                ");
#nullable restore
#line 89 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                           Write(Model[i].CheckOutDate.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-4"">
                                        <div class=""row"">
                                            <div class=""col-12"">
                                                <b>Hizmet Pak.</b>
                                            </div>
                                            <div class=""col-12"">
                                                ");
#nullable restore
#line 99 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                           Write(Model[i].VMServicePack.PackName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-12"">
                                        <hr />
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-4"">
                                        <div class=""row"">
                                            <div class=""col-12"">
                                                <b>Tutar</b>
                                            </div>
                                            <div class=""col-12"">
                                                ");
#nullable restore
#line 114 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                           Write(Model[i].DiscountedPrice.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-4"">
                                        <div class=""row"">
                                            <div class=""col-12"">
                                                <b>Ödeme Dur.</b>
                                            </div>
                                            <div class=""col-12"">
");
#nullable restore
#line 124 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                                 if (Model[i].Payment)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"text-success\">Ödendi</span>\r\n");
#nullable restore
#line 127 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"text-danger\">Ödenmedi</span>\r\n");
#nullable restore
#line 131 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-4"">
                                        <div class=""row"">
                                            <div class=""col-12"">
                                                <b>Durum</b>
                                            </div>
                                            <div class=""col-12"">
                                                ");
#nullable restore
#line 141 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                           Write(Model[i].ReservationStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-12"">
                                        <hr />
                                    </div>
                                </div>
");
#nullable restore
#line 149 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                 if (Model[i].ReservationStatus == Entities.Enum.ReservationStatus.RezervasyonAlindi && (Model[i].CheckInDate.Date - DateTime.Now.Date).TotalDays > 2)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"row\">\r\n                                        <div class=\"col-12 d-flex justify-content-end\">\r\n                                            ");
#nullable restore
#line 153 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                       Write(Html.ActionLink("İptal Et", "CancelWebReservation", "Reservation", new { id = Model[i].ID }, new { @class = "btn btn-danger w-100" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 156 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 161 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <section id=""contact"" class=""contact mt-5"">
                <div class=""container"">
                    <div class=""row justify-content-center"" data-aos=""fade-up"">
                        <div class=""col-10 php-email-form"">
                            <div class=""row"">
                                <div class=""col-md-6 d-flex align-items-center justify-content-center"">
                                    <a href=""/Home/Index"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f8eb36c331296fb6ebd095c789b57cc4650c007622259", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                                </div>
                                <div class=""col-md-6"">
                                    <div><h6>Rezervasyonlarım</h6></div>

                                    <p>Daha önce oluşturulmuş bir rezervasyonunuz bulunmamaktadır.</p>
                                    <p>Odalarımızı görüntülemek için Odalar sekmesinden odalarımıza ulaşabilirsiniz.</p>
                                    <p>Erken rezervasyon fırsatlarıyla indirimli rezervasyon oluşturmak için <a href=""/Reservation/WebReservation"">Rezervasyon</a> butonuna tıklayabilirsiniz.</p><br />
                                    <i>Saygılarımızla,</i><br />
                                    <i>Bilge Hotel</i>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
");
#nullable restore
#line 188 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Views\Account\MyReservations.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VMMyReservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
