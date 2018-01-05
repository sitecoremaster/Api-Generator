using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Constants.Settings
{
    public class Path
    {
        // Templates
        public const string TemplateIdString = "{CEF71CCB-6FBB-4644-8FF9-DB2BA249F41B}";
        public static readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public static readonly ID TitleFieldId = new ID("{516B8D61-B694-47AD-B8B0-80590CF9A622}");
        public const string TitleFieldName = "Title";

        public static readonly ID EndpointPathFieldId = new ID("{B8FBFE57-A5A7-4971-B7C5-E742E266C4CD}");
        public const string EndpointPathFieldName = "EndpointPath";
    }
}