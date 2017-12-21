using Sitecore.ContentSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.ApiGenerator.Models.Search
{
    public class PathSearchItem : BaseSearchItem
    {
        [IndexField("endpointpath")]
        public string EndpointPath { get; set; }
    }
}