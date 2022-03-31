using ContainerAppMvc.DataAccess;
using ContainerAppMvc.DataAccess.TodoApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainerAppMvc
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            //DbContext container'a scoped olarak ekleniyor.
            services.AddDbContext<TodoAppDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IQuotesDal, QuotesDal>();
            services.AddScoped<IWeatherDal, WeatherDal>();
            services.AddScoped<ITodoAppDal, EfTodoAppDal>();

        }
    }
}
