using AutoMapper;
using Business.Services.Abstract;
using Common;
using Core.Entities.Enum;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.HomePage;

namespace WebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles ="admin")]
    public class HomePageController : Controller
    {
        private readonly IMapper mapper;
        private readonly IHomePageService homePageService;
        private readonly IResult result;
        private readonly IHomePageSlideService homePageSlideService;

        public HomePageController(IMapper mapper, IHomePageService homePageService, IResult result, IHomePageSlideService homePageSlideService)  
        {
            this.mapper = mapper;
            this.homePageService = homePageService;
            this.result = result;
            this.homePageSlideService = homePageSlideService;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["HomePageResult"] != null)
            {
                var homePageResult = JsonConvert.DeserializeObject<Result>(TempData["HomePageResult"].ToString());
                ViewBag.HomePageResult = homePageResult;
            }

            var homePages = await homePageService.GetAll();
            var vmHomePages = mapper.Map<List<VMHomePage>>(homePages);

            return View(vmHomePages);
        }
        public IActionResult HomePageCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HomePageCreate(VMHomePageCreate vMHomePageCreate, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var uploadResult = ImageUploader.UploadImage("/img/", file, (Result)result);
                if (uploadResult.ResultStatus == ResultStatus.Success)
                {
                    var pictureUrl = uploadResult.Message;
                    vMHomePageCreate.PictureUrl = pictureUrl;

                    var homePage = mapper.Map<HomePage>(vMHomePageCreate);
                    var createResult = homePageService.Create(homePage);

                    TempData["HomePageResult"] = JsonConvert.SerializeObject(createResult);
                    return RedirectToAction("Index");

                }
                else
                {
                    TempData["HomePageResult"] = JsonConvert.SerializeObject(uploadResult);
                }
            }
            return View(vMHomePageCreate);            
            
            
        }
        public async Task<IActionResult> RemoveForce(int id)
        {
            if (await homePageService.Any(x => x.ID == id))
            {
                var deleteResult = homePageService.RemoveForce(id);
                TempData["HomePageResult"] = JsonConvert.SerializeObject(deleteResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı.";
                TempData["HomePageResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateHomePage(int id)
        {
            if (TempData["HomePageResult"] != null)
            {
                var homePageResult = JsonConvert.DeserializeObject<Result>(TempData["HomePageResult"].ToString());
                ViewBag.HomePageResult = homePageResult;
            }

            var homePage = await homePageService.GetById(id);
            if (homePage != null)
            {
                var vmHomePage = mapper.Map<VMHomePageUpdate>(homePage);
                return View(vmHomePage);
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
        public async Task<IActionResult> UpdateHomePage(VMHomePageUpdate vMHomePageUpdate, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var homePage = await homePageService.GetById(vMHomePageUpdate.HomePageID);
                homePage.Title = vMHomePageUpdate.Title;
                homePage.Subtitle = vMHomePageUpdate.Subtitle;
                homePage.Paragraph1 = vMHomePageUpdate.Paragraph1;
                homePage.Paragraph2 = vMHomePageUpdate.Paragraph2;
                homePage.Paragraph3 = vMHomePageUpdate.Paragraph3;
                homePage.Paragraph4 = vMHomePageUpdate.Paragraph4;
                homePage.Paragraph5 = vMHomePageUpdate.Paragraph5;

                var uploadResult = ImageUploader.UploadImage("/img/", file, (Result)result);
                if (uploadResult.ResultStatus == ResultStatus.Success)
                {                   
                    homePage.PictureUrl = uploadResult.Message;
                }
                var updateResult = homePageService.Update(homePage);
                ViewBag.HomePageResult = updateResult;
            }
            return View(vMHomePageUpdate);
        }
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var homePage = await homePageService.GetById(id);
            if (homePage != null)
            {
                if (homePage.Status == Status.Active)
                {
                    homePage.Status = Status.Deleted;
                }
                else if (homePage.Status == Status.Deleted)
                {
                    homePage.Status = Status.Active;
                }
                var updateResult = homePageService.Update(homePage);
                TempData["HomePageResult"] = JsonConvert.SerializeObject(updateResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı";
                TempData["HomePageResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("Index");
        }
        //Slide pictures control
        public async Task<IActionResult> SlidePictures(int id)
        {
            if (TempData["HomePageResult"] != null)
            {
                var homePageResult = JsonConvert.DeserializeObject<Result>(TempData["HomePageResult"].ToString());
                ViewBag.HomePageResult = homePageResult;
            }

            if (await homePageService.Any(x => x.ID == id))
            {
                var slidePictures = await homePageSlideService.GetDefault(x => x.HomePageID == id);
                var vmSlidePictures = mapper.Map<List<VMHomePageSlide>>(slidePictures);
                ViewBag.HomePageId = id;
                return View(vmSlidePictures);
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
        public IActionResult SlidePictureUpload(VMHomePageSlide vMHomePageSlide, IFormFile file)
        {
            if (vMHomePageSlide.PictureName != null)
            {
                var uploadResult = ImageUploader.UploadImage("/img/slide/", file, (Result)result);
                if (uploadResult.ResultStatus == ResultStatus.Success)
                {
                    var pictureUrl = uploadResult.Message;
                    vMHomePageSlide.PictureUrl = pictureUrl;

                    var slidePicture = mapper.Map<HomePageSlide>(vMHomePageSlide);
                    var imageCreateResult = homePageSlideService.Create(slidePicture);

                    TempData["HomePageResult"] = JsonConvert.SerializeObject(imageCreateResult);
                }
                else
                {
                    TempData["HomePageResult"] = JsonConvert.SerializeObject(uploadResult);
                }
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Görsel adı boş bırakılamaz.";
                TempData["HomePageResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("SlidePictures", new { id = vMHomePageSlide.HomePageID });
        }
        public async Task<IActionResult> PictureDeActivate(int id)
        {
            var homePageId = (await homePageSlideService.GetDefault(x => x.ID == id)).FirstOrDefault().HomePageID;
            if (await homePageService.Any(x => x.ID == homePageId))
            {
                var deleteResult = homePageSlideService.Delete(id);

                TempData["HomePageResult"] = JsonConvert.SerializeObject(deleteResult);
            }

            return RedirectToAction("SlidePictures", new { id = homePageId });
        }
        public async Task<IActionResult> PictureActivate(int id)
        {
            var slidePicture = await homePageSlideService.GetById(id);
            if (slidePicture != null && slidePicture.Status != Status.Active)
            {
                slidePicture.Status = Status.Active;
                var updateResult = homePageSlideService.Update(slidePicture);

                TempData["PictureResult"] = JsonConvert.SerializeObject(updateResult);

            }
            return RedirectToAction("SlidePictures", new { id = slidePicture.HomePageID });
        }

        public async Task<IActionResult> PictureRemoveForce(int id)
        {
            var homePageId = (await homePageSlideService.GetDefault(x => x.ID == id)).FirstOrDefault().HomePageID;
            if (await homePageSlideService.Any(x => x.ID == id))
            {
                var deleteResult = homePageSlideService.RemoveForce(id);

                TempData["HomePageResult"] = JsonConvert.SerializeObject(deleteResult);
            }

            return RedirectToAction("SlidePictures", new { id = homePageId });
        }
    }
}
