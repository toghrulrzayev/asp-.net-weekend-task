using ChimberdTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace ChimberdTemplate.Models
{
    public class HomeViewModel
    {
        public List<Models.Aboutu> Aboutus { get; set; }
        public List<Models.Blog> Blog { get; set; }
        public List<Models.FirstSlider> Slider { get; set; }
        public List<Models.Project> Project { get; set; }
        public List<Models.Service> Service { get; set; }
        public List<Models.Setting> Setting { get; set; }
        public List<Models.Testimonial> Testimonial { get; set; }
        public List<Models.ServiceItem> SItem { get; set; }
        public List<Models.Word> Words { get; set; }

    }
}