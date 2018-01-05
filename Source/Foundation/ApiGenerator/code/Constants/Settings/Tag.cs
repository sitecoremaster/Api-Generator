using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Constants.Settings
{
    public class Tag
    {
        // Templates
        public const string TemplateIdString = "{B6634D58-49D5-435A-AC86-8E47FA7E7939}";
        public static readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public static readonly ID TitleFieldId = new ID("{96974DE4-6BF4-40EE-87B5-446C19BDEAAC}");
        public const string TitleFieldName = "Title";
    }
}