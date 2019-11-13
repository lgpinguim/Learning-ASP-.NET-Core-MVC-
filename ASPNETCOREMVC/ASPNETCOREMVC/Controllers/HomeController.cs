using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCOREMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCOREMVC.Controllers
{
    public class HomeController : Controller
    {

        [HttpPost]
        [HttpGet]
        public IActionResult Index(HomeModel form)
        {
            LoadDataList();
            return View();
        }


        public void LoadDataList()
        {
            HomeModel objHomeModel = new HomeModel();
            ViewBag.list = objHomeModel.GetAll(); // send information between the view and the controller
        }

    }
}