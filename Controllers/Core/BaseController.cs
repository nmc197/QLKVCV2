using Microsoft.AspNetCore.Mvc;
using QuanLyKVC.Controllers.Core;

namespace QuanLyKVC.Controllers.Core
{
    public class BaseController : Controller
    {
        private readonly ICacheHelper _cacheHelper;
        public BaseController(ICacheHelper cacheHelper)
        {
            _cacheHelper = cacheHelper;
        }
    }
}