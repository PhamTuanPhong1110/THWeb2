using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace THWeb2.Controllers
{
    public class UserController : Controller
    {
        // Hàm script để trong phần Body của trang HTMl
        //Sử dụng hợp thoại Prompt để nhập liệu
        //Sử dụng hàm document.write để hiện thị dữ liệu
        public ActionResult Welcome()
        {
            return View();
        }
        //Hàm script để trong phần tử body của trang HTML
        //Sử dụng input type=text để nhập liệu
        //Sử dụng hộp thoại Alert để hiển thị thông tin
        public ActionResult Welcome2()
        {
            return View();
        }
        public ActionResult Welcome3()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}