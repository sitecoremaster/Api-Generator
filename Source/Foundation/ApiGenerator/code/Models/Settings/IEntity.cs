using Glass.Mapper.Sc.Configuration.Attributes;
using SitecoreMaster.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMaster.Foundation.ApiGenerator.Models.Settings
{
    [SitecoreType(TemplateId = Constants.Settings.Entity.TemplateIdString)]
    public interface IEntity : IGlassBase
    {
        [SitecoreField(Constants.Settings.Entity.TitleFieldName)]
        string Title { get; set; }

        [SitecoreField(Constants.Settings.Entity.EntityTypeFieldName)]
        ILookupValue EntityType { get; set; }

        [SitecoreField(Constants.Settings.Entity.RequiredFieldName)]
        bool Required { get; set; }

        [SitecoreField(Constants.Settings.Entity.ExampleFieldName)]
        string Example { get; set; }

        [SitecoreField(Constants.Settings.Entity.FormatFieldName)]
        string Format { get; set; }
    }
}
