﻿using ChimberdTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChimberdTemplate.Controllers
{
    public class MainController : Controller
    {

      protected  ChimperdEntities1 db = new ChimperdEntities1();
            protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
            {
                string lang = null;
                HttpCookie langCookie = Request.Cookies["culture"];
                if (langCookie != null)
                {
                    lang = langCookie.Value;
                }
                else
                {
                    var userLanguage = Request.UserLanguages;
                    var userLang = userLanguage != null ? userLanguage[0] : "";
                    if (userLang != "")
                    {
                        lang = userLang;
                    }
                    else
                    {
                        lang = LanguageMang.GetDefaultLanguage();
                    }
                }
                new LanguageMang().SetLanguage(lang);
                return base.BeginExecuteCore(callback, state);
            }
        
       
    }
}