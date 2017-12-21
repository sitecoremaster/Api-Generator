using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreMaster.Foundation.ApiGenerator.Models.Settings;
using Sitecore.ContentSearch.SearchTypes;
using SitecoreMaster.Foundation.ApiGenerator.Models.Search;
using Sitecore.ContentSearch.Linq;
using SitecoreMaster.Foundation.Search.Extensions;
using Sitecore.ContentSearch;
using SitecoreMaster.Foundation.ApiGenerator.Repository.Interfaces;

namespace SitecoreMaster.Foundation.ApiGenerator.Repository
{
    public class DefinitionRepository : IDefinitionRepository
    {
        public IEnumerable<IDefinition> GetAll()
        {
            using (var context = ContentSearchManager.CreateSearchContext(new SitecoreIndexableItem(Sitecore.Context.Item)))
            {
                IQueryable<DefinitionSearchItem> query = context.GetQueryable<DefinitionSearchItem>();

                query.Where(i => i.TemplateId == Constants.Definition.TemplateId);

                return query.GenerateResults<IDefinition, DefinitionSearchItem>();
            }
        }

        public IDefinition GetByName(string name)
        {
            if (!string.IsNullOrEmpty(name))
                return null;

            using (var context = Sitecore.ContentSearch.ContentSearchManager.CreateSearchContext(new Sitecore.ContentSearch.SitecoreIndexableItem(Sitecore.Context.Item)))
            {
                IQueryable<DefinitionSearchItem> query = context.GetQueryable<DefinitionSearchItem>();

                query.Where(i => i.TemplateId == Constants.Definition.TemplateId);
                query.Where(i => i.DefinitionName == name);

                return query.GenerateResults<IDefinition, DefinitionSearchItem>().FirstOrDefault();
            }
        }
    }
}