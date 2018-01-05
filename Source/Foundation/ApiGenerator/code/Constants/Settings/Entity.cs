using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Constants.Settings
{
    public class Entity
    {
        // Templates
        public const string TemplateIdString = "{05CE05AA-4A15-4A49-943D-3B2699FEF8DC}";
        public static readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public static readonly ID TitleFieldId = new ID("{8A8C8A02-51AA-4854-A4FD-257AED55371E}");
        public const string TitleFieldName = "Title";

        public static readonly ID EntityTypeFieldId = new ID("{5D061281-2AE7-48B9-A9B7-89E693EB2468}");
        public const string EntityTypeFieldName = "EntityType";

        public static readonly ID RequiredFieldId = new ID("{5D061281-2AE7-48B9-A9B7-89E693EB2468}");
        public const string RequiredFieldName = "Required";

        public static readonly ID ExampleFieldId = new ID("{E7EE5FE2-412B-4E2A-9C9C-3AEC941E9707}");
        public const string ExampleFieldName = "Example";

        public static readonly ID FormatFieldId = new ID("{C4DB74D3-676B-4A03-B550-E356B7D595B0}");
        public const string FormatFieldName = "Format";
    }
}