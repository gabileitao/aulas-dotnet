using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API2.Controllers {
    public class AulaController : ApiController {

        [HttpGet, Route("oi")]
        public string HelloWorld() {
            return "Hello World!";
        }

        [HttpGet, Route("catch")]
        public Pokemon PegarPokemon() {
            Pokemon p1 = new Pokemon();
            p1.Name = "Pikachu";
            p1.Type = "Electric";

            return p1;
        }

        [HttpPost, Route("send")]
        public Pokemon EnviarPokemon([FromBody]Pokemon p) {
            p.Name = p.Name + " oi";
            p.Type = "tchau " + p.Type;

            return p;
        }

    }
}