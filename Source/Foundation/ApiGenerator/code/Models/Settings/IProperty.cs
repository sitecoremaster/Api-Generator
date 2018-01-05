using Glass.Mapper.Sc.Configuration.Attributes;
using SitecoreMaster.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMaster.Foundation.ApiGenerator.Models.Settings
{
    [SitecoreType(TemplateId = Constants.Settings.Property.TemplateIdString)]
    public interface IProperty : IGlassBase
    {
        [SitecoreField(Constants.Settings.Property.TitleFieldName]
        string Title { get; set; }

        [SitecoreField(Constants.Settings.Property.EntityTypeFieldName)]
        ILookupValue EntityType { get; set; }

        [SitecoreField(Constants.Settings.Property.RequiredFieldName)]
        bool Required { get; set; }

        [SitecoreField(Constants.Settings.Property.MappedFieldFieldName)]
        Guid MappedField { get; set; }
    }
}
