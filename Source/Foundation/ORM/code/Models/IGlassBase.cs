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
        [SitecoreInfo(SitecoreInfoType.Name)]
        string ItemName { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; set; }
    }
}