using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Data;

namespace Template.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ITemplateData data) : base(data)
        {
        }

        public ActionResult Index()
        {
            return this.View();
            
        }
        
    }
}