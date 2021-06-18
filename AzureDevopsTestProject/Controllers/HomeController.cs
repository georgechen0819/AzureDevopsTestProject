using AzureDevopsTestProject.Models.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureDevopsTestProject.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            //test change from TFVS v5
            ViewBag.Title = System.Configuration.ConfigurationManager.AppSettings["PageTitle"];
        }

        public ActionResult Index()
        {
            ViewBag.MessageBox = "Test CI 3";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Member()
        {
            throw new Exception();
            MemberViewModel memberVM = new MemberViewModel();
            memberVM.Name = "George_0506";
            string temp = JsonConvert.SerializeObject(memberVM);

            memberVM = JsonConvert.DeserializeObject<MemberViewModel>(temp);

            return View(memberVM);
        }
    }
}