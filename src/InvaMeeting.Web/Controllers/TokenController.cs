using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvaMeetings.Web.Controllers
{
    public class TokenController : Controller
    {
        HttpContext context;

        public TokenController(HttpContext context)
        {
            this.context = context;
        }


    }
}
