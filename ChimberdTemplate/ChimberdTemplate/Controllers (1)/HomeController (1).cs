using ChimberdTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChimberdTemplate.DAL;
using System.Threading;

namespace ChimberdTemplate.Controllers
{
    public class HomeController : MainController
    {
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();

            List<Translate> sozler = db.Translates.ToList();
            List<Word> words = new List<Word>();
            string cult = Thread.CurrentThread.CurrentUICulture.Name;
            if (cult == "en")
            {
                 Word word;
                foreach (var item in sozler)
                {
                   word = new Word()
                    {
                        Keyword = item.Keyword,
                        Value = item.English
                    };
                    words.Add(word);
                    model.Words = words;
                }
              
            }
            if (cult == "az")
            {
                foreach (var item in sozler)
                {
                    Word word = new Word()
                    {
                        Keyword = item.Keyword,
                        Value = item.Az
                    };
                    words.Add(word);
                    model.Words = words;
                }
            }

           
            model.Aboutus = db.Aboutus.ToList();
            model.Blog = db.Blogs.ToList();
            model.Project = db.Projects.ToList();

            model.Service = db.Services.ToList();
            model.Setting = db.Settings.ToList();
            model.Slider = db.FirstSliders.ToList();
            model.Testimonial = db.Testimonials.ToList();


            return View(model);
        }

        public ActionResult ChangeLanguage(string lang)
        {
            new LanguageMang().SetLanguage(lang);
            return RedirectToAction("Index","Home");
        }

    }
}