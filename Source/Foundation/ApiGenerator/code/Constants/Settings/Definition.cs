using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Constants.Settings
{
    public static class Definition
    {
        // Templates
        public const string TemplateIdString = "{C4DB74D3-676B-4A03-B550-E356B7D595B0}";
        public static readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public static readonly ID NameFieldId = new ID("{22B40DD0-230E-4576-91E0-94160FA1288C}");
        public const string NameFieldName = "Name";

        public static readonly ID VersionFieldId = new ID("{11B0AA9C-AED0-4402-80FB-792D4E1A0314}");
        public const string VersionFieldName = "Version";

        public static readonly ID DescriptionFieldId = new ID("{872241E0-A98B-4102-8673-B89D015D4A19}");
        public const string DescriptionFieldName = "Description";
    }
}