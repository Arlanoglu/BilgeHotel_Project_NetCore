using AutoMapper;
using Business.Services.Abstract;
using Common;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Account;
using WebUI.Models.Reservation;
using WebUI.Models.RoomType;
using WebUI.Models.ServicePack;
using WebUI.Utilities;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IWebReservationService webReservationService;
        private readonly ISettingService settingService;

        public AccountController(IMapper mapper, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IWebReservationService webReservationService, ISettingService settingService)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.webReservationService = webReservationService;
            this.settingService = settingService;
        }
        public IActionResult Login()
        {
            ViewBag.LoginSuccess = TempData["LoginSuccess"];
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(VMLogin vMLogin)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(vMLogin.Email);
                if (user!=null)
                {
                    if (user.EmailConfirmed)
                    {
                        var result = await signInManager.PasswordSignInAsync(user, vMLogin.Password, false, false);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            ViewBag.LoginError = "Giriş bilgileri hatalı.";
                            return View(vMLogin);
                        }
                    }
                    else
                    {
                        ViewBag.LoginError = "Eposta adresiniz doğrulanmammış. Lütfen mail adresinize gönderilen aktivasyon linkine tıklayın.";
                        return View(vMLogin);
                    }
                }
                else
                {
                    ViewBag.LoginError = "Giriş bilgileri hatalı.";
                    return View(vMLogin);
                }
            }
            else
            {
                ViewBag.LoginError = "Giriş Gerçekleştirilemedi.";
                return View(vMLogin);
            }
            
        }
        public IActionResult AuthorizedLogin()
        {
            ViewBag.LoginSuccess = TempData["LoginSuccess"];
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AuthorizedLogin(VMLogin vMLogin)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(vMLogin.Email);
                if (user != null)
                {
                    if (user.EmailConfirmed)
                    {
                        var result = await signInManager.PasswordSignInAsync(user, vMLogin.Password, false, false);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "Home", new { Area = "Administrator" });
                        }
                        else
                        {
                            ViewBag.LoginError = "Giriş bilgileri hatalı.";
                            return View(vMLogin);
                        }
                    }
                    else
                    {
                        ViewBag.LoginError = "Eposta adresiniz doğrulanmammış. Lütfen mail adresinize gönderilen aktivasyon linkine tıklayın.";
                        return View(vMLogin);
                    }
                }
                else
                {
                    ViewBag.LoginError = "Giriş bilgileri hatalı.";
                    return View(vMLogin);
                }
            }
            else
            {
                ViewBag.LoginError = "Giriş Gerçekleştirilemedi.";
                return View(vMLogin);
            }

        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login","Account");
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(VMRegister vMRegister)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(vMRegister.Email);
                if (user==null)
                {
                    var appUser = mapper.Map<AppUser>(vMRegister);
                    appUser.UserName = vMRegister.Email;
                    appUser.ActivationKey = Guid.NewGuid().ToString();
                    appUser.CreatedDate = DateTime.Now;

                    var result = await userManager.CreateAsync(appUser, vMRegister.Password);
                    var roleResult = await userManager.AddToRoleAsync(appUser, "user");

                    if (result.Succeeded && roleResult.Succeeded)
                    {
                        
                        ViewBag.AppUser = appUser;
                        var setting = await settingService.GetActive();
                        var message = MailSender.RegisterActivationMessage(appUser.ActivationKey, "Account", "AccountActivation");
                        var mailResult = MailSender.SendMail(appUser.Email, "Üyelik", message, setting.FirstOrDefault());
                        if (mailResult==1)
                        {
                            ViewBag.RegisterSuccess = "Kullanıcı kayıt işlemi başarıyla gerçekleştirildi. Lütfen girmiş olduğunuz mail adresine gönderilen aktivasyon linkine tıklayarak üyelik işleminizi onaylayınız.";
                        }
                        else
                        {
                            ViewBag.RegisterSuccess = "Kullanıcı kayıt işleminiz bayarıyla gerçekleştirildi. Ancak aktivasyon mail gönderimi sırasında bir hata meydana geldi. Sorun çözümü için lütfen iletişim bölümünden iletişime geçmenizi rica ederiz.";
                        }
                        return View();
                    }
                    else
                    {
                        ViewBag.RegisterError = "Kayıt gerçekleştirilemedi.";
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError(item.Code, item.Description);
                        }
                        return View(vMRegister);
                    }
                }
                else
                {
                    ViewBag.RegisterError = "Kullanıcı zaten mevcut!";
                    return View(vMRegister);
                }

                
            }
            else
            {
                ViewBag.RegisterError = "Kayıt gerçekleştirilemedi.";
                return View(vMRegister);
            }
        }

        public async Task<IActionResult> SendActivationAgain(string email, string activationKey)
        {
            var setting = await settingService.GetActive();
            var message = MailSender.RegisterActivationMessage(activationKey, "Account", "AccountActivation");
            MailSender.SendMail(email, "Üyelik", message, setting.FirstOrDefault());

            ViewBag.RegisterSuccess = "Aktivasyon linki gönderildi. Lütfen girmiş olduğunuz mail adresine gönderilen aktivasyon linkine tıklayarak üyelik işleminizi onaylayınız.";

            return RedirectToAction("Register");
        }
        public async Task<IActionResult> AccountActivation(Guid id)
        {
            var result = userManager.Users.Any(x => x.ActivationKey == id.ToString());
            if (result)
            {
                var appUser = userManager.Users.Where(x => x.ActivationKey == id.ToString()).FirstOrDefault();
                if (appUser.EmailConfirmed)
                {
                    TempData["LoginSuccess"] = "Hesabınız zaten aktif. Giriş yapabilirsiniz.";
                    return RedirectToAction("Login");
                }
                else
                {
                    appUser.EmailConfirmed = true;
                    await userManager.UpdateAsync(appUser);

                    TempData["LoginSuccess"] = "Aktivasyon işlemi gerçekleştirildi. Giriş yapabilirsiniz.";
                    return RedirectToAction("Login");
                }

            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public async Task<IActionResult> MyReservations(string id)
        {
            var reservations = await webReservationService.GetDefault(x => x.AppUserID == id);
            var vmMyReservations = mapper.Map<List<VMMyReservation>>(reservations);

            for (int i = 0; i < vmMyReservations.Count; i++)
            {
                vmMyReservations[i].VMRoomTypeName = mapper.Map<VMRoomTypeName>(reservations[i].RoomType);
                vmMyReservations[i].VMServicePack = mapper.Map<VMServicePack>(reservations[i].ServicePack);
            }

            return View(vmMyReservations);
        }
        public IActionResult Denied()
        {
            return View();
        }
        public IActionResult ForgotMyPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotMyPassword(string email)
        {
            if (TempData["PasswordError"] != null)
            {
                ViewBag.PasswordError = TempData["PasswordError"];
            }
            var user = await userManager.FindByEmailAsync(email);

            if (user != null)
            {
                user.ActivationKey = Guid.NewGuid().ToString();
                await userManager.UpdateAsync(user);

                //Mail gönderimi başarılı olursa;
                var setting = await settingService.GetActive();
                var message = MailSender.PasswordUpdateActivationMessage(user.ActivationKey, "Account", "PasswordUpdate");
                var mailResult = MailSender.SendMail(user.Email, "Şifre Güncelleme", message, setting.FirstOrDefault());
                if (mailResult == 1)
                {
                    ViewBag.PasswordSuccess = "Şifre güncelleme işlemi için aktivasyon kodu mail adresinize gönderildi. Gönderilen linki tıklayarak şifrenizi güncelleyebilirsiniz.";
                }
                else
                {
                    ViewBag.PasswordError = "Beklenmeyen bir hata meydana geldi lütfen tekrar deneyin";
                }
            }
            else
            {
                ViewBag.PasswordError = "Eposta adresi hatalı veya kayıtlı değil.";
            }

            return View();
        }
        public IActionResult PasswordUpdate(Guid id)
        {
            var result = userManager.Users.Any(x => x.ActivationKey == id.ToString());
            if (result)
            {
                var appUser = userManager.Users.Where(x => x.ActivationKey == id.ToString()).FirstOrDefault();
                var vmPasswordUpdate = mapper.Map<VMPasswordUpdate>(appUser);
                vmPasswordUpdate.Email = appUser.Email;
                return View(vmPasswordUpdate);
            }
            else
            {
                ViewBag.PasswordError = "Aktivasyon kodu geçerli değil.";
                return View("ForgotMyPassword");
            }
        }
        [HttpPost]
        public async Task<IActionResult> PasswordUpdate(VMPasswordUpdate vMPasswordUpdate)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(vMPasswordUpdate.Email);
                user.ActivationKey = null;
                user.PasswordHash = userManager.PasswordHasher.HashPassword(user, vMPasswordUpdate.Password);
                var result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    TempData["LoginSuccess"] = "Şifreniz başarıyla güncellendi.";
                    return RedirectToAction("Login");
                }
                else
                {
                    TempData["PasswordError"] = "İşlem sırasında bir hata meydana geldi lütfen tekrar deneyin";
                    return View("ForgotMyPassword");
                }
            }
            else
            {
                return View(vMPasswordUpdate);
            }
        }

    }
}
