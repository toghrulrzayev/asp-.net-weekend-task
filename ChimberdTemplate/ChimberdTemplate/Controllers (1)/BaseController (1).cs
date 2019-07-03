using ChimberdTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChimberdTemplate.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected ChimperdEntities1 db;
        public BaseController()
        {
            db = new ChimperdEntities1();
        }
    }
}