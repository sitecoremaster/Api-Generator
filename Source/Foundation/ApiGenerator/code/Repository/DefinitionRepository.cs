using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreMaster.Foundation.ApiGenerator.Models.Settings;
using Sitecore.ContentSearch.SearchTypes;
using SitecoreMaster.Foundation.ApiGenerator.Models.Search;
using Sitecore.ContentSearch.Linq;

namespace SitecoreMaster.Foundation.ApiGenerator.Repository
{
    public class DefinitionRepository : IDefinitionRepository
    {
        public IEnumerable<IDefinition> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDefinition GetByName(string name)
        {
            if (!string.IsNullOrEmpty(name))
                return null;

            using (var context = Sitecore.ContentSearch.ContentSearchManager.CreateSearchContext(new Sitecore.ContentSearch.SitecoreIndexableItem(Sitecore.Context.Item)))
            {
                IQueryable<DefinitionSearchItem> query = context.GetQueryable<DefinitionSearchItem>();

                query.Where(i => i.Paths.Contains());

                query.Where(i => i.TemplateId.Guid == Constants.Definition.TemplateId.Guid);

                query.Where(i => i.DefinitionName == name);

                SearchResults<DefinitionSearchItem> results = query.GetResults();

                if (results != null && results.Any())
                {
                    return results.Where(i => i.Document != null).Select(i => i.Document.GetItem());
                }
            }
        }
    }
}