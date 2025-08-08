using DevFramework.Northwind.Business.Abstract;
using DevFrameWork.Core.CrossCuttingConcerns.Security.Web;
using System;
using System.Linq;
using System.Web.Mvc;

namespace DevFramework.Northwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: Account
        public string Login(string userName, string password)
        {
            var user = _userService.GetByUserNameAndPassword(userName, password);
            var userRoles = _userService.GetUserRoles(user).Select(u => u.RoleName).ToArray();
            if (user != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                    new Guid(), user.UserName, user.Email, DateTime.Now.AddDays(15), userRoles, false, user.FirstName, user.FirstName);
                return "User is authenticated!";
            }
            return "User is not authenticated!";
        }
    }
}