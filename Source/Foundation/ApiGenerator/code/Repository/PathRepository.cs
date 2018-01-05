using SitecoreMaster.Foundation.ApiGenerator.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreMaster.Foundation.ApiGenerator.Models.Settings;
using Sitecore.ContentSearch.Linq;
using SitecoreMaster.Foundation.Search.Extensions;
using Sitecore.ContentSearch;
using Sitecore;
using SitecoreMaster.Foundation.ApiGenerator.Models.Search;
using Sitecore.Data;

namespace SitecoreMaster.Foundation.ApiGenerator.Repository
{
    public class PathRepository : IPathRepository
    {

        public IPath GetByEndpointPath(string path, IDefinition definition)
        {
            using (var context = ContentSearchManager.CreateSearchContext(new SitecoreIndexableItem(Context.Item)))
            {
                IQueryable<PathSearchItem> query = context.GetQueryable<PathSearchItem>();

                query = query.Where(i => i.Paths.Contains(new ID(definition.ItemId)));
                query = query.Where(i => i.TemplateId == Constants.Path.PathTemplateId);
                query = query.Where(i => i.EndpointPath == path);

                IEnumerable<IPath> results = query.GenerateResults<IPath, PathSearchItem>();

                return results.FirstOrDefault();
            }
        }
    }
}