using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net.Http;
using System.Web.Mvc;
using Turner;
using Turner.Controllers;

namespace Turner.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
         
            return View();
        }

        public ActionResult About()
        {
            
            
            return View();
        }

        public ActionResult Contact(string id)
        {
            ViewBag.Message = "Movie Details";

            TitleGenresController tgc = new TitleGenresController();
            ViewBag.titlegenreabout = tgc.GetTitleGenrebyid(id);

            TitleParticipantsController tpc = new TitleParticipantsController();
            ViewBag.titleparticipantabout=  tpc.GetTitleParticipantByid(id);

            AwardsController ac = new AwardsController();
            ViewBag.awardabout  =  ac.GetAwardid(id);

            return View();
        }
    }
}