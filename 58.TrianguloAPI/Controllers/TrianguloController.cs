using _58.TrianguloAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace _58.TrianguloAPI.Controllers {
    public class TrianguloController : ApiController{

        [HttpPost, Route("triangulo")]
        public string VerifyTriangleType([FromBody] Triangulo t1) {
            return t1.GetTriangleType();
        }

    }
}