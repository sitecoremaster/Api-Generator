using Glass.Mapper.Sc.Configuration.Attributes;
using SitecoreMaster.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMaster.Foundation.ApiGenerator.Models.Settings
{
    [SitecoreType(TemplateId = "{A7DC8F8E-F004-46C8-9E31-B2BA852E3DF3}")]
    public interface ILookupValue : IGlassBase
    {
        [SitecoreField(FieldId = "{2C9E1974-F4A6-4DD1-9E7A-D3EFA85AE339}")]
        string Key { get; set; }

        [SitecoreField(FieldId = "{DD48A3BD-D48D-4109-8519-037A30A52257}")]
        string Value { get; set; }
    }
}
