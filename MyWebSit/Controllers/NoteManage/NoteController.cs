﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebSit.Controllers.NoteManage
{
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index()
        {
            return View("Page_Note");
        }
        public ActionResult Test()
        {
            return View("View");
        }
    }
}