using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Constants.Settings
{
    public class HttpVerb
    {
        // Templates
        public const string TemplateIdString = "{0E2F5663-20E2-4448-BAE2-58A42377E19B}";
        public static readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public static readonly ID TitleFieldId = new ID("{2CF9F216-5526-4A4A-B9E0-AEB1C794AACE}");
        public const string TitleFieldName = "Title";

        public static readonly ID SummaryFieldId = new ID("{9C440FF8-4094-4987-8B1D-0AB3EAB13B51}");
        public const string SummaryFieldName = "Summary";

        public static readonly ID DescriptionFieldId = new ID("{5D98B67A-1C83-48BB-9DE3-2ACF6C6EF193}");
        public const string DescriptionFieldName = "Description"

        public static readonly ID VerbTypeFieldId = new ID("{2AD0AC83-1735-4CB5-A216-A5ABEBF8996E}");
        public const string VerbTypeFieldName = "VerbType";

        public static readonly ID ProducesFieldId = new ID("{ED102D9C-0689-4970-95C8-EDA9BFEFE3FD}");
        public const string ProducesFieldName = "Produces";

        public static readonly ID ConsumesFieldId = new ID("{B16B2475-861B-4257-8236-A692B3BA0DC1}");
        public const string ConsumesFieldName = "Consumes";

        public static readonly ID TagsFieldId = new ID("{9769CEEB-4DEB-4E0A-A94F-C177E9898C14}");
        public const string TagsFieldName = "Tags";
    }
}