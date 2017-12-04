using Sitecore.ContentSearch.Linq;
using SitecoreMaster.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreMaster.Foundation.Search.Extensions
{
    public class QueryableExtensions
    {
        public static IEnumerable<TGlassModel> GenerateResults<TGlassModel, TSearchType>(this IQueryable<TSearchType> query)
            where TGlassModel : class, IGlassBase
        {
            var searchResults = query.GetResults<TSearchType>();
            IEnumerable<TGlassModel> results;

            if (searchResults != null && searchResults.Any())
            {
                var context = new SitecoreContext();
                results = searchResults.Where(i => i.Document != null).Select(i => i.Document.GetType());
            }
        }


    }
}