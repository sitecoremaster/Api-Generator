using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ORM.Models
{
    public interface IGlassBase
    {
        [SitecoreId]
        Guid ItemId { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        string ItemName { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; set; }

        [SitecoreInfo(SitecoreInfoType.Path)]
        string Path { get; set; }

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        string DisplayName { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        string TemplateName { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        string Url { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        string Language { get; set; }

        [SitecoreInfo(SitecoreInfoType.FullPath)]
        string FullPath { get; set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; set; }
    }
}