﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xadrez.Controllers
{
    public class Usuario : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult  Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Apagar()
        {
            return View();
        }

    }
}
