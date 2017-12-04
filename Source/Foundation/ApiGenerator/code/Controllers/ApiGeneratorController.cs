using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SitecoreMaster.Foundation.ApiGenerator.Controllers
{
    public class ApiGeneratorController : ApiController
    {

        public ApiGeneratorController()
        {
        }

        [HttpGet, HttpPost, HttpPut, HttpDelete]
        public async Task<IHttpActionResult> Generate(string definition, string path)
        {
            if (string.IsNullOrEmpty(definition))
                return NotFound();

            if (string.IsNullOrEmpty(path))
                return NotFound();

            // Get Definition Information
            

            return Ok(new { Something = "true" });
        }
    }
}
