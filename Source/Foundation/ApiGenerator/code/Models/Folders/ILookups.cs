using Glass.Mapper.Sc.Configuration.Attributes;
using SitecoreMaster.Foundation.ApiGenerator.Models.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMaster.Foundation.ApiGenerator.Models.Folders
{
    [SitecoreType(TemplateId = "")]
    public interface ILookups
    {
        [SitecoreChildren]
        IEnumerable<ILookupValue> Values { get; set; }
    }
}