using Glass.Mapper.Sc.Configuration.Attributes;
using SitecoreMaster.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMaster.Foundation.ApiGenerator.Models.Settings
{
    [SitecoreType(TemplateId = "{05CE05AA-4A15-4A49-943D-3B2699FEF8DC}")]
    public interface IObject : IGlassBase
    {
        [SitecoreField(FieldId = "{8A8C8A02-51AA-4854-A4FD-257AED55371E}")]
        string Title { get; set; }

        [SitecoreField(FieldId = "{5D061281-2AE7-48B9-A9B7-89E693EB2468}")]
        ILookupValue Type { get; set; }

        [SitecoreField(FieldId = "{73A98460-27E2-4706-9E5A-9793F7A1EF8A}")]
        bool Required { get; set; }
    }
}
