using SitecoreMaster.Foundation.ApiGenerator.Models.Settings;
using SitecoreMaster.Foundation.ApiGenerator.Services;
using SitecoreMaster.Foundation.ApiGenerator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace SitecoreMaster.Foundation.ApiGenerator.Controllers
{
    public class ApiGeneratorController : ApiController
    {
        private readonly IDefinitionService _definitionService;
        private readonly IPathService _pathService;

        public ApiGeneratorController(IDefinitionService definitionService, IPathService pathService)
        {
            _definitionService = definitionService;
            _pathService = pathService;
        }

        [AcceptVerbs("GET", "POST", "PUT", "DELETE")]
        public async Task<IHttpActionResult> Generate(string definition, string path)
        {
            if (string.IsNullOrEmpty(definition))
                return NotFound();

            if (string.IsNullOrEmpty(path))
                return NotFound();

            // Get Definition Information
            IDefinition definitionItem = _definitionService.GetByName(definition);

            if (definitionItem == null)
                return NotFound();

            IPath pathItem = _pathService.GetByEndpointPath(path, definitionItem);

            if (pathItem == null)
                return NotFound();

            // Process Path
            if (pathItem.HttpVerb.Value != HttpContext.Current.Request.HttpMethod)
                return NotFound();

            ProcessEndpointPath(pathItem);

            return Ok(new { Something = "true" });
        }

        private void ProcessEndpointPath(IPath pathItem)
        {


        }
    }
}
