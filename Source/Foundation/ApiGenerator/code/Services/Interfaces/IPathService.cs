using SitecoreMaster.Foundation.ApiGenerator.Models.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Services.Interfaces
{
    public interface IPathService
    {
        IPath GetByEndpointPath(string path, IDefinition definition);

        IEnumerable<IPath> GetByDefinition(IDefinition definition);
    }
}