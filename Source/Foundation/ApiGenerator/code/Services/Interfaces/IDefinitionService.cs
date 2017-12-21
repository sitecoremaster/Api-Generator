using SitecoreMaster.Foundation.ApiGenerator.Models.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Services.Interfaces
{
    public interface IDefinitionService
    {
        IEnumerable<IDefinition> GetAll();

        IDefinition GetByName(string name);
    }
}