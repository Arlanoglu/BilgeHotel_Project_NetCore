using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Reservation;
using Core.Utilities.Results.Concrete;
using Newtonsoft.Json;
using Entities.Enum;
using Common;

namespace WebUI.Areas.Reception.Controllers
{
    [Area("Reception")]
    public class ReservationController : Controller
    {
        private readonly IMapper mapper;
        private readonly IWebReservationService webReservationService;
        private readonly IReceptionReservationService receptionReservationService;
        private readonly IResult result;
        private readonly ISettingService settingService;

        public ReservationController(IMapper mapper, IWebReservationService webReservationService, IReceptionReservationService receptionReservationService, IResult result, ISettingService settingService)
        {
            this.mapper = mapper;
            this.webReservationService = webReservationService;
            this.receptionReservationService = receptionReservationService;
            this.result = result;
            this.settingService = settingService;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["ReservationResult"] != null)
            {
                var reservationResult = JsonConvert.DeserializeObject<Result>(TempData["ReservationResult"].ToString());
                ViewBag.ReservationResult = reservationResult;
            }
            var webReservations = await webReservationService.GetAll();
            var receptionReservations = await receptionReservationService.GetAll();
            var vmReservations = mapper.Map<List<VMReservationList>>(webReservations);
            var vmReceptionReservations = mapper.Map<List<VMReservationList>>(receptionReservations);

            vmReservations.AddRange(vmReceptionReservations);
            return View(vmReservations);
        }
        public async Task<IActionResult> ReservationDetail(ReservationType reservationType, int id)
        {
            if (TempData["ReservationResult"] != null)
            {
                var reservationResult = JsonConvert.DeserializeObject<Result>(TempData["ReservationResult"].ToString());
                ViewBag.ReservationResult = reservationResult;
            }
            if (reservationType == ReservationType.Web)
            {
                var webReservation = await webReservationService.GetById(id);
                if (webReservation!=null)
                {
                    var vmWebReservation = mapper.Map<VMReservationDetail>(webReservation);

                    return View(vmWebReservation);
                }
                else
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "İlgili idye ait rezervasyon kaydı bulunmamaktadır.";
                    TempData["ReservationResult"] = JsonConvert.SerializeObject(result);

                    return RedirectToAction("Index");
                }
                
            }
            else if (reservationType == ReservationType.Reception)
            {
                var receptionReservation = await receptionReservationService.GetById(id);
                if (receptionReservation!=null)
                {
                    var vmReceptionReservation = mapper.Map<VMReservationDetail>(receptionReservation);

                    return View(vmReceptionReservation);
                }
                else
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "İlgili idye ait rezervasyon kaydı bulunmamaktadır.";
                    TempData["ReservationResult"] = JsonConvert.SerializeObject(result);

                    return RedirectToAction("Index");
                }
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili rezervasyon kaydı bulunmamaktadır.";
                TempData["ReservationResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> ChangePayment(ReservationType reservationType, int id)
        {
            if (reservationType==ReservationType.Web)
            {
                var webReservation = await webReservationService.GetById(id);
                if (webReservation.Payment)
                    webReservation.Payment = false;
                else
                    webReservation.Payment = true;
                var updateResult = webReservationService.Update(webReservation);

                TempData["ReservationResult"] = JsonConvert.SerializeObject(updateResult);                
            }
            else if (reservationType == ReservationType.Reception)
            {
                var receptionReservation = await receptionReservationService.GetById(id);
                if (receptionReservation.Payment)
                    receptionReservation.Payment = false;
                else
                    receptionReservation.Payment = true;
                var updateResult = receptionReservationService.Update(receptionReservation);

                TempData["ReservationResult"] = JsonConvert.SerializeObject(updateResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili rezervasyon kaydı bulunmamaktadır.";
                TempData["ReservationResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("ReservationDetail", new { reservationType = reservationType, id = id });
        }

        public async Task<IActionResult> CancelReservation(ReservationType reservationType, int id)
        {
            if (reservationType == ReservationType.Web)
            {
                var webReservation = await webReservationService.GetById(id);
                var setting = (await settingService.GetActive()).FirstOrDefault();
                var cancelResult = webReservationService.CancelReservation(webReservation);

                //Rezervasyon iptal mail gönderimi.
                if (cancelResult.ResultStatus == ResultStatus.Success)
                {
                    var message = MailSender.CancelReservationMessage(webReservation.ID, webReservation.CheckInDate, webReservation.CheckOutDate);
                    //Kullanıcıya gönderilen mail.
                    MailSender.SendMail(webReservation.AppUser.Email, "Rezervasyon İptal", message, setting);
                    if (webReservation.AppUser.Email != webReservation.Email)
                    {
                        //Rezervasyon yapan kişinin bilgilerine gönderilen mail.
                        MailSender.SendMail(webReservation.Email, "Rezervasyon İptal", message, setting);
                    }
                }
                TempData["ReservationResult"] = JsonConvert.SerializeObject(cancelResult);
            }
            else if (reservationType == ReservationType.Reception)
            {
                var receptionReservation = await receptionReservationService.GetById(id);
                var setting = (await settingService.GetActive()).FirstOrDefault();
                var cancelResult = receptionReservationService.CancelReservation(receptionReservation);

                //Rezervasyon iptal mail gönderimi.
                if (cancelResult.ResultStatus == ResultStatus.Success && receptionReservation.Email!=null)
                {
                    var message = MailSender.CancelReservationMessage(receptionReservation.ID, receptionReservation.CheckInDate, receptionReservation.CheckOutDate);
                    //Rezervasyon yapan kişinin bilgilerine gönderilen mail.
                    MailSender.SendMail(receptionReservation.Email, "Rezervasyon İptal", message, setting);
                }

                TempData["ReservationResult"] = JsonConvert.SerializeObject(cancelResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili rezervasyon kaydı bulunmamaktadır.";
                TempData["ReservationResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("ReservationDetail", new { reservationType = reservationType, id = id });

        }
    }
}
