#pragma checksum "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07da12f6d0f066b334bf46578d2e583a44f77d47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_ServicePack_UpdateServicePack), @"mvc.1.0.view", @"/Areas/Administrator/Views/ServicePack/UpdateServicePack.cshtml")]
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
#line 1 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI.Models.RoomType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI.Models.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI.Models.Aboutus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI.Models.HotelService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI.Models.Reservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI.Models.ServicePack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI.Models.Registration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI.Models.Guest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI.Models.Room;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI.Models.RoomFacility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using WebUI.Models.ExtraService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using Core.Utilities.Results.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using Core.Entities.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\_ViewImports.cshtml"
using Entities.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07da12f6d0f066b334bf46578d2e583a44f77d47", @"/Areas/Administrator/Views/ServicePack/UpdateServicePack.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e7130accf183965caca259632484264ecd2a54a", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_ServicePack_UpdateServicePack : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VMServicePackUpdate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ServicePack", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Zorunlu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateServicePack", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml"
  
    ViewData["Title"] = "UpdateServicePack";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0"">Hizmet Paketleri</h1>
            </div><!-- /.col -->
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""/Administrator/Home/Index"">Ana Sayfa</a></li>
                    <li class=""breadcrumb-item active"">Hizmet Paketleri</li>
                </ol>
            </div><!-- /.col -->
            <div class=""col-12"">
            </div>
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<!-- /.content-header -->

<div class=""container"">
");
#nullable restore
#line 28 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml"
     if (ViewBag.ServicePackResult != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mb-3\">\r\n");
#nullable restore
#line 31 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml"
             if (ViewBag.ServicePackResult.ResultStatus == ResultStatus.Success)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col alert-success\">\r\n                    <span>");
#nullable restore
#line 34 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml"
                     Write(ViewBag.ServicePackResult.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n");
#nullable restore
#line 36 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col alert-danger\">\r\n                    <span>");
#nullable restore
#line 40 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml"
                     Write(ViewBag.ServicePackResult.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n");
#nullable restore
#line 42 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 44 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07da12f6d0f066b334bf46578d2e583a44f77d4715064", async() => {
                WriteLiteral("<i class=\"nav-icon far ion-arrow-left-b\"></i> Hizmet Paketleri");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07da12f6d0f066b334bf46578d2e583a44f77d4716571", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07da12f6d0f066b334bf46578d2e583a44f77d4716838", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 47 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ServicePackID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml"
                                                WriteLiteral(Model.ServicePackID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <div class=\"form-row d-flex justify-content-center\">\r\n            <div class=\"col-md-6\">\r\n                <div class=\"col-12 form-group\">\r\n                    <label class=\"col-form-label\">Hizmet Paketi Adı</label>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07da12f6d0f066b334bf46578d2e583a44f77d4719658", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 52 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PackName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 form-group\">\r\n                    <label class=\"col-form-label\">Fiyatı</label>\r\n                    ");
#nullable restore
#line 56 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml"
               Write(Html.TextBoxFor(x => x.PackPrice, new { @class = "form-control", @type = "currency" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 form-group\">\r\n                    <label class=\"col-form-label\">Açıklama</label>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07da12f6d0f066b334bf46578d2e583a44f77d4722343", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 60 "C:\Users\arlan\source\repos\Repositories\BilgeHotel_Project_NetCore\BilgeHotelProject\WebUI\Areas\Administrator\Views\ServicePack\UpdateServicePack.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-12 form-group d-flex justify-content-center\">\r\n                    <button class=\"btn btn-primary\" type=\"submit\">Güncelle</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VMServicePackUpdate> Html { get; private set; }
    }
}
#pragma warning restore 1591
