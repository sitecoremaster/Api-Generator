using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Constants.Settings
{
    public class Parameter
    {
        // Templates
        public const string TemplateIdString = "";
        public static readonly ID TemplateId = new ID("");

        // Fields
        public static readonly ID TitleFieldId = new ID("");
        public const string TitleFieldName = "";

        public static readonly ID DescriptionFieldId = new ID("");
        public const string DescriptionFieldName = "";

        public static readonly ID EntityTypeFieldId = new ID("");
        public const string EntityTypeFieldName = "";

        public static readonly ID IsRequiredFieldId = new ID("");
        public const string IsRequiredFieldName = "";

        public static readonly ID ParameterTypeFieldId = new ID("");
        public const string ParameterTypeFieldName = "";
    }
}