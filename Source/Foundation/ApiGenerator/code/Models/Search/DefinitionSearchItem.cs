using Sitecore.ContentSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Models.Search
{
    public class DefinitionSearchItem : BaseSearchItem
    {
        [IndexField("name")]
        public string DefinitionName { get; set; }
    }
}