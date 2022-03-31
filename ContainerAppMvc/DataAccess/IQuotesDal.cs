using ContainerAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainerAppMvc.DataAccess
{
    public interface IQuotesDal
    {
        Task<IEnumerable<QuoteModel>>  GetAllQuotesAsync();
    }
}
