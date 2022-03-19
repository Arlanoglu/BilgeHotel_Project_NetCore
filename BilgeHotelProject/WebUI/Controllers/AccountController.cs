using AutoMapper;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Account;
using WebUI.Utilities;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AccountController(IMapper mapper, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Login()
        {
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
                    var result = await signInManager.PasswordSignInAsync(user, vMLogin.Password, false, false);
                    if (result.Succeeded)
                    {
                        //Session İşlemleri yapılacak.
                        var vmUser = mapper.Map<VMUserSession>(user);
                        HttpContext.Session.SetObject("user", vmUser);
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

                    var result = await userManager.CreateAsync(appUser, vMRegister.Password);
                    var roleResult = await userManager.AddToRoleAsync(appUser, "user");

                    if (result.Succeeded && roleResult.Succeeded)
                    {
                        ViewBag.RegisterSuccess = "Kullanıcı kayıt işlemi başarıyla gerçekleştirildi.";
                        //Todo: Mail gönderme ve aktivasyon işlemi gerçekleştirilecek.
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
    }
}
