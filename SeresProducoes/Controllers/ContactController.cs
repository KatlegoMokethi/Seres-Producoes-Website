﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Controllers
{
    [Route("[controller]")]
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
