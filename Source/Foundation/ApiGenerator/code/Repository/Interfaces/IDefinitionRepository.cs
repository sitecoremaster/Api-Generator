using SitecoreMaster.Foundation.ApiGenerator.Models.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Repository.Interfaces
{
    public interface IDefinitionRepository
    {
        IEnumerable<IDefinition> GetAll();
        IDefinition GetByName(string name);
    }
}