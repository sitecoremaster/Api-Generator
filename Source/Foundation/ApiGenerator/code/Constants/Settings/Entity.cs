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
        public const string TemplateIdString = "";
        public static readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public static readonly ID TitleFieldId = new ID("");
        public const string TitleFieldName = "Title";

        public static readonly ID EntityTypeFieldId = new ID("");
        public const string EntityTypeFieldName = "EntityType";

        public static readonly ID RequiredFieldId = new ID("");
        public const string RequiredFieldName = "Required";

        public static readonly ID ExampleFieldId = new ID("");
        public const string ExampleFieldName = "Example";

        public static readonly ID FormatFieldId = new ID("");
        public const string FormatFieldName = "Format";
    }
}