using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Data;

namespace Template.Web.Controllers
{
    abstract public class BaseController : Controller
    {
        protected BaseController(ITemplateData data)
        {
            this.Data = data;
        }

        public ITemplateData Data { get; set; }

    }
}