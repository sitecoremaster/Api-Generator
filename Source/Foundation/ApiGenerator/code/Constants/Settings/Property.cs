using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Constants.Settings
{
    public class Property
    {
        // Templates
        public const string TemplateIdString = "{261F68D1-531C-4D9E-B051-8AB535172ACB}";
        public static readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public static readonly ID TitleFieldId = new ID("{3843BB2C-6304-4A7E-B638-02F2A264FE52}");
        public const string TitleFieldName = "Title";

        public static readonly ID EntityTypeFieldId = new ID("{51A5163B-8F95-4E90-80A9-325238B16F6A}");
        public const string EntityTypeFieldName = "EntityType";

        public static readonly ID RequiredFieldId = new ID("{82B9EDF4-9672-4F2A-8CA6-3A2D722FB435}");
        public const string RequiredFieldName = "Required";

        public static readonly ID MappedFieldFieldId = new ID("{C638C5F0-8F36-46A4-9621-98528FD9EAF1}");
        public const string MappedFieldFieldName = "MappedField";
    }
}