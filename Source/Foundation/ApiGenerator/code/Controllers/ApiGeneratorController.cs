using SitecoreMaster.Foundation.ApiGenerator.Models.Settings;
using SitecoreMaster.Foundation.ApiGenerator.Services;
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
        private readonly IDefinitionService _definitionService;

        public ApiGeneratorController(IDefinitionService definitionService)
        {
            _definitionService = definitionService;
        }

        [HttpGet, HttpPost, HttpPut, HttpDelete]
        public async Task<IHttpActionResult> Generate(string definition, string path)
        {
            if (string.IsNullOrEmpty(definition))
                return NotFound();

            if (string.IsNullOrEmpty(path))
                return NotFound();

            // Get Definition Information
            IDefinition definitionItem = _definitionService.GetByName(definition);

            if (definitionItem != null)
            {
                //definitionItem.
            }

            return Ok(new { Something = "true" });
        }
    }
}
