using SitecoreMaster.Foundation.ApiGenerator.Models.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMaster.Foundation.ApiGenerator.Repository.Interfaces
{
    public interface IPathRepository
    {
        IPath GetByEndpointPath(string path, IDefinition definition);
    }
}
