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
        public const string TemplateIdString = "";
        public static readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public static readonly ID KeyFieldId = new ID("");
        public const string KeyFieldName = "";

        public static readonly ID ValueFieldId = new ID("");
        public const string ValueFieldName = "";
   
    }
}