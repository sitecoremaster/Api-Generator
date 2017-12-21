using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Models.Settings
{
    [SitecoreType(TemplateId = "")]
    public interface IResponse
    {
        Guid StatusCode { get; set; }

        string Description { get; set; }
    }
}