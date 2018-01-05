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
        public const string TemplateIdString = "{3D8B8DF8-36C4-4060-A391-2E7A92A83BED}";
        public static readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public static readonly ID TitleFieldId = new ID("{B070754A-BA19-4CBC-8BA9-9B0E1CB41ACC}");
        public const string TitleFieldName = "Title";

        public static readonly ID DescriptionFieldId = new ID("{FF88D061-BEFA-43BA-AC51-2D517EBAD7A5}");
        public const string DescriptionFieldName = "Description";

        public static readonly ID EntityTypeFieldId = new ID("{CD14A3D1-D9C5-4B14-ABD0-7CD22DE9039A}");
        public const string EntityTypeFieldName = "EntityType";

        public static readonly ID RequiredFieldId = new ID("{650E3A22-044A-46DE-8173-0CEE02BCF3EB}");
        public const string RequiredFieldName = "Required";

        public static readonly ID ParameterTypeFieldId = new ID("{A8B2929B-2DD8-4504-810D-2A7E87E9171D}");
        public const string ParameterTypeFieldName = "ParameterType";
    }
}