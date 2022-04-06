using AutoMapper;
using Business.Services.Abstract;
using Common;
using Core.Entities.Enum;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Aboutus;
using WebUI.Models.Picture;

namespace WebUI.Areas.Administrator.Controllers
{
    public class AboutusController : Controller
    {
        private readonly IMapper mapper;
        private readonly IAboutusService aboutusService;
        private readonly IPictureService pictureService;
        private readonly IResult result;

        public AboutusController(IMapper mapper, IAboutusService aboutusService, IPictureService pictureService, IResult result)
        {
            this.mapper = mapper;
            this.aboutusService = aboutusService;
            this.pictureService = pictureService;
            this.result = result;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["AboutusResult"] != null)
            {
                var aboutusResult = JsonConvert.DeserializeObject<Result>(TempData["AboutusResult"].ToString());
                ViewBag.AboutusResult = aboutusResult;
            }

            var aboutus = await aboutusService.GetAll();
            var vmAboutus = mapper.Map<List<VMAboutus>>(aboutus);

            return View(vmAboutus);
        }
        public IActionResult AboutusCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AboutusCreate(VMAboutusCreate vMAboutusCreate, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var uploadResult = ImageUploader.UploadImage("/img/", file, (Result)result);
                if (uploadResult.ResultStatus == ResultStatus.Success)
                {
                    var pictureUrl = uploadResult.Message;
                    vMAboutusCreate.PictureUrl = pictureUrl;

                    var aboutus = mapper.Map<Aboutus>(vMAboutusCreate);
                    var createResult = aboutusService.Create(aboutus);

                    TempData["AboutusResult"] = JsonConvert.SerializeObject(createResult);
                    return RedirectToAction("Index");

                }
                else
                {
                    TempData["AboutusResult"] = JsonConvert.SerializeObject(uploadResult);
                }
            }
            return View(vMAboutusCreate);


        }
        public async Task<IActionResult> RemoveForce(int aboutusId)
        {
            if (await aboutusService.Any(x => x.ID == aboutusId))
            {
                var deleteResult = aboutusService.RemoveForce(aboutusId);
                TempData["AboutusResult"] = JsonConvert.SerializeObject(deleteResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı.";
                TempData["AboutusResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateAboutus(int aboutusId)
        {
            if (TempData["AboutusResult"] != null)
            {
                var aboutusResult = JsonConvert.DeserializeObject<Result>(TempData["AboutusResult"].ToString());
                ViewBag.AboutusResult = aboutusResult;
            }

            var aboutus = await aboutusService.GetById(aboutusId);
            if (aboutus != null)
            {
                var vmAboutus = mapper.Map<VMAboutusUpdate>(aboutus);
                return View(vmAboutus);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı.";
                TempData["HomePageResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAboutus(VMAboutusUpdate vMAboutusUpdate, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var aboutus = await aboutusService.GetById(vMAboutusUpdate.AboutusID);
                aboutus.Title = vMAboutusUpdate.Title;
                aboutus.Paragraph1 = vMAboutusUpdate.Paragraph1;
                aboutus.Paragraph2 = vMAboutusUpdate.Paragraph2;
                aboutus.Paragraph3 = vMAboutusUpdate.Paragraph3;
                aboutus.Paragraph4 = vMAboutusUpdate.Paragraph4;
                aboutus.Paragraph5 = vMAboutusUpdate.Paragraph5;

                var uploadResult = ImageUploader.UploadImage("/img/", file, (Result)result);
                if (uploadResult.ResultStatus == ResultStatus.Success)
                {
                    aboutus.PictureUrl = uploadResult.Message;
                }
                var updateResult = aboutusService.Update(aboutus);
                ViewBag.AboutusResult = updateResult;
            }
            return View(vMAboutusUpdate);
        }
        public async Task<IActionResult> ChangeStatus(int aboutusId)
        {
            var aboutus = await aboutusService.GetById(aboutusId);
            if (aboutus != null)
            {
                if (aboutus.Status == Status.Active)
                {
                    aboutus.Status = Status.Deleted;
                }
                else if (aboutus.Status == Status.Deleted)
                {
                    aboutus.Status = Status.Active;
                }
                var updateResult = aboutusService.Update(aboutus);
                TempData["AboutusResult"] = JsonConvert.SerializeObject(updateResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı";
                TempData["AboutusResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("Index");
        }
        //Slide pictures control
        public async Task<IActionResult> GalleryPictures(int aboutusId)
        {
            if (TempData["AboutusResult"] != null)
            {
                var aboutusResult = JsonConvert.DeserializeObject<Result>(TempData["AboutusResult"].ToString());
                ViewBag.AboutusResult = aboutusResult;
            }

            if (await aboutusService.Any(x => x.ID == aboutusId))
            {
                var pictures = await pictureService.GetDefault(x => x.AboutusID == aboutusId);
                var vmPictures = mapper.Map<List<VMPicture>>(pictures);
                ViewBag.AboutusId = aboutusId;
                return View(vmPictures);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı.";
                TempData["AboutusResult"] = JsonConvert.SerializeObject(result);
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult GalleryPictureUpload(VMPicture vMPicture, IFormFile file)
        {
            if (vMPicture.PictureName != null)
            {
                var uploadResult = ImageUploader.UploadImage("/img/Gallery/", file, (Result)result);
                if (uploadResult.ResultStatus == ResultStatus.Success)
                {
                    var pictureUrl = uploadResult.Message;
                    vMPicture.PictureUrl = pictureUrl;

                    var picture = mapper.Map<Picture>(vMPicture);
                    var imageCreateResult = pictureService.Create(picture);

                    TempData["AboutusResult"] = JsonConvert.SerializeObject(imageCreateResult);
                }
                else
                {
                    TempData["AboutusResult"] = JsonConvert.SerializeObject(uploadResult);
                }
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Görsel adı boş bırakılamaz.";
                TempData["AboutusResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("GalleryPictures", new { aboutusId = vMPicture.AboutusID });
        }
        public async Task<IActionResult> PictureChangeStatus(int pictureId)
        {
            var picture = await pictureService.GetById(pictureId);
            if (picture != null)
            {
                if (picture.Status == Status.Active)
                {
                    picture.Status = Status.Deleted;
                }
                else if (picture.Status == Status.Deleted)
                {
                    picture.Status = Status.Active;
                }
                var updateResult = pictureService.Update(picture);
                TempData["AboutusResult"] = JsonConvert.SerializeObject(updateResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı";
                TempData["AboutusResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("GalleryPictures", new { aboutusId = picture.AboutusID });
        }
        public async Task<IActionResult> PictureRemoveForce(int pictureId)
        {
            var aboutusId = (await pictureService.GetDefault(x => x.ID == pictureId)).FirstOrDefault().AboutusID;
            if (await pictureService.Any(x => x.ID == pictureId))
            {
                var deleteResult = pictureService.RemoveForce(pictureId);

                TempData["AboutusResult"] = JsonConvert.SerializeObject(deleteResult);
            }

            return RedirectToAction("GalleryPictures", new { aboutusId = aboutusId });
        }
    }
}
