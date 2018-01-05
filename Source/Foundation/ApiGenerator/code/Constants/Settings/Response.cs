using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Constants.Settings
{
    public class Response
    {
        // Templates
        public const string TemplateIdString = "{712F04E3-83D9-4400-811C-629BBC4BD267}";
        public static readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public static readonly ID StatusCodeFieldId = new ID("{1704C4B1-5AF1-4309-BC0F-3A32EB1F44B0}");
        public const string StatusCodeFieldName = "StatusCode";

        public static readonly ID DescriptionFieldId = new ID("{AF70CEB5-6128-44A2-AE59-BFFC7C41762D}");
        public const string DescriptionFieldName = "Description";
    }
}