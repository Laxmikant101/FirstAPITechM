﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetData()
        {
            return "welcome";
        }

        [HttpGet]
        public ActionResult<string> GetData()
        {
            return "Shrivalli";
        }
       
       [HttpGet]
        public ActionResult<string> GetLA()
        {
            return "LA";
        }
    }
}
