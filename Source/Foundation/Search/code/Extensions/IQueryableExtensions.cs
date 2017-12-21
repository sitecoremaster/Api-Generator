using Glass.Mapper.Sc;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.Linq.Lucene;
using SitecoreMaster.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.ContentSearch.Linq.Utilities;
using Sitecore.ContentSearch.SearchTypes;


namespace SitecoreMaster.Foundation.Search.Extensions
{
    public static class QueryableExtensions
    {
        public static IEnumerable<TGlassModel> GenerateResults<TGlassModel, TSearchType>(this IQueryable<TSearchType> query)
            where TGlassModel : class, IGlassBase
            where TSearchType : SearchResultItem
        {
            var searchResults = query.GetResults<TSearchType>();

            if (searchResults != null && searchResults.TotalSearchResults > 0)
            {
                IEnumerable<TSearchType> data = searchResults.Hits.Where(i => i.Document != null).Select(i => i.Document);

                if (data == null && data.Any())
                    return null;

                var service = new SitecoreService(Sitecore.Context.Database);

                var resultSet = data.Select(i => service.CreateType<TGlassModel>(i.GetItem()));

                return resultSet;
            }

            return null;
        }


    }
}