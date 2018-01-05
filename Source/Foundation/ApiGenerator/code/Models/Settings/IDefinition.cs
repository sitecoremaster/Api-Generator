using Glass.Mapper.Sc.Configuration.Attributes;
using SitecoreMaster.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Models.Settings
{
    [SitecoreType(TemplateId = "{C07EC43F-EF3A-4073-B6CD-0F3FF6EAF6F5}")]
    public interface IDefinition : IGlassBase
    {
        [SitecoreField(Constants.Definition.FieldId = "{22B40DD0-230E-4576-91E0-94160FA1288C}")]
        string Name { get; set; }

        [SitecoreField(FieldId = "{11B0AA9C-AED0-4402-80FB-792D4E1A0314}")]
        string ApiVersion { get; set; }

        [SitecoreField(FieldId = "{872241E0-A98B-4102-8673-B89D015D4A19}")]
        string Description { get; set; }
    }
}