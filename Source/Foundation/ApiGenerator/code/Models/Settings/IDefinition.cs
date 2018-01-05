using Glass.Mapper.Sc.Configuration.Attributes;
using SitecoreMaster.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Models.Settings
{
    [SitecoreType(TemplateId = Constants.Settings.Definition.TemplateIdString)]
    public interface IDefinition : IGlassBase
    {
        [SitecoreField(Constants.Settings.Definition.NameFieldName)]
        string Name { get; set; }

        [SitecoreField(Constants.Settings.Definition.VersionFieldName)]
        string ApiVersion { get; set; }

        [SitecoreField(Constants.Settings.Definition.DescriptionFieldName)]
        string Description { get; set; }
    }
}