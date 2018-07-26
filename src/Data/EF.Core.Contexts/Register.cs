namespace EF.Core.Contexts
{
    using EF.Core.Contexts.Contexts;
    using EF.Core.Entities.Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class Register
    {
        public static void Configure(IServiceCollection services, Settings settings)
        {
            AddDB(services, settings);
        }

        private static void AddDB(IServiceCollection services, Settings settings)
        {
            services.AddDbContext<BuaAmbulanceContext>(o => o.UseSqlServer(settings.ConnectionStrings.BuaAmbulance));
        }
    }
}
