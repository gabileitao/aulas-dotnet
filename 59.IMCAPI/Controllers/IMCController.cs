using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace _59.IMCAPI.Controllers {
    public class IMCController : ApiController {

        [HttpPost, Route("imc")]
        public string YourIMC([FromBody] IMC i1) {
            return i1.VerifyIMC();
        }

    }
}