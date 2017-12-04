using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMaster.Foundation.ApiGenerator.Models.Settings
{
    [SitecoreType(TemplateId = "{261F68D1-531C-4D9E-B051-8AB535172ACB}")]
    public interface IProperty
    {
        [SitecoreField(FieldId = "{3843BB2C-6304-4A7E-B638-02F2A264FE52}")]
        string Title { get; set; }

        [SitecoreField(FieldId = "{51A5163B-8F95-4E90-80A9-325238B16F6A}")]
        ILookupValue Type { get; set; }

        [SitecoreField(FieldId = "{82B9EDF4-9672-4F2A-8CA6-3A2D722FB435}")]
        bool Required { get; set; }

        [SitecoreField(FieldId = "{C638C5F0-8F36-46A4-9621-98528FD9EAF1}")]
        Guid MappedField { get; set; }
    }
}
