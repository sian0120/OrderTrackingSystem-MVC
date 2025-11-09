using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderTrackingSystem.Dtos;//dto加入
using System.Security.Claims;//安全性登入
namespace OrderTrackingSystem.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            //登出語法
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }
        //登入帳號密碼DTO
        [HttpPost]
        public IActionResult Index(LoginDto value)
        {

            if (value.Account.ToLower() == "TalllKai".ToLower() && value.Password == "123456")//比對帳號密碼是否有錯
            {
                //目前使用者是誰
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, value.Account),
                    new Claim("FullName", "kai")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                //登入畫面
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "帳號或密碼錯誤!";
                return View(value);

            }
        }
    }
}
