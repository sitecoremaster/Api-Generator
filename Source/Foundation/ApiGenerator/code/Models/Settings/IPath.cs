using Glass.Mapper.Sc.Configuration.Attributes;
using SitecoreMaster.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMaster.Foundation.ApiGenerator.Models.Settings
{
    [SitecoreType(TemplateId = Constants.Settings.Path.TemplateIdString)]
    public interface IPath : IGlassBase
    {
        [SitecoreField(Constants.Settings.Path.TitleFieldName)]
        string Title { get; set; }

        [SitecoreField(Constants.Settings.Path.EndpointPathFieldName)]
        string EndpointPath { get; set; }
    }
}