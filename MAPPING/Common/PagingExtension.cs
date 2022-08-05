using DATA.Errors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAPPING.Common
{
    public static class PagingExtension
    {
        public static async Task<IEnumerable<T>> GetPagedAsync<T>(
            this IQueryable<T> query,
            int page,
            int take)
        {
            var originalPages = page;

            page--;
            if (page > 0)
                page = page * take;

            var result = new DataCollection<T>
            {
                Items = await query.Skip(page).Take(take).ToListAsync(),
                Total = await query.CountAsync(),
                Page = originalPages
            };
            if (result.Total > 0)
            {
                result.Pages = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(result.Total) / take));
            }
            if (result.Pages < page)
            {
                throw new EmptyCollectionException("La colección no poseé mas de" + " " + result.Pages + " " + "pagina/as");
            }

            return result.Items;
        }
    }
}
