using Glass.Mapper.Sc.Configuration.Attributes;
using SitecoreMaster.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMaster.Foundation.ApiGenerator.Models.Settings
{
    [SitecoreType(TemplateId = "{CEF71CCB-6FBB-4644-8FF9-DB2BA249F41B}")]
    public interface IPath : IGlassBase
    {
        [SitecoreField(FieldId = "{516B8D61-B694-47AD-B8B0-80590CF9A622}")]
        string Title { get; set; }

        [SitecoreField(FieldId = "{0F3615DF-4746-496F-ABB5-5EB1AF41E7B6}")]
        string Summary { get; set; }

        [SitecoreField(FieldId = "{F65BA9DD-0DA4-4A3E-A67E-4F9004B9B1AA}")]
        string Description { get; set; }

        [SitecoreField(FieldId = "{B8FBFE57-A5A7-4971-B7C5-E742E266C4CD}")]
        string EndpointPath { get; set; }

        [SitecoreField(FieldId = "{C1ADED6C-BB92-4620-AEA9-3125D1ABCD8C}")]
        ILookupValue HttpVerb { get; set; }

        [SitecoreField(FieldId = "{6C20F12B-4101-4613-AD14-7A968CBC2491}")]
        ILookupValue Output { get; set; }
    }
}