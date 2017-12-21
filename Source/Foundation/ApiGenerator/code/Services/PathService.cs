using SitecoreMaster.Foundation.ApiGenerator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreMaster.Foundation.ApiGenerator.Models.Settings;
using SitecoreMaster.Foundation.ApiGenerator.Repository.Interfaces;

namespace SitecoreMaster.Foundation.ApiGenerator.Services
{
    public class PathService : IPathService
    {
        private readonly IPathRepository _pathRepository;

        public PathService(IPathRepository pathRepository)
        {
            _pathRepository = pathRepository;
        }

        public IEnumerable<IPath> GetByDefinition(IDefinition definition)
        {
            throw new NotImplementedException();
        }

        public IPath GetByEndpointPath(string path, IDefinition definition)
        {
            IPath result = _pathRepository.GetByEndpointPath(path, definition);

            return result;
        }
    }
}