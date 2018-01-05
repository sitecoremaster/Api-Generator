using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Constants.Settings
{
    public class LookupValue
    {
        // Templates
        public const string TemplateIdString = "{A7DC8F8E-F004-46C8-9E31-B2BA852E3DF3}";
        public static readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public static readonly ID KeyFieldId = new ID("{2C9E1974-F4A6-4DD1-9E7A-D3EFA85AE339}");
        public const string KeyFieldName = "Key";

        public static readonly ID ValueFieldId = new ID("{DD48A3BD-D48D-4109-8519-037A30A52257}");
        public const string ValueFieldName = "Value";
    }
}