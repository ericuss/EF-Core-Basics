namespace EF.Core.Contexts.Contexts
{
    using Microsoft.EntityFrameworkCore;
    using EF.Core.Entities;
    using EF.Core.Contexts.contexts.Core;
    using Microsoft.AspNetCore.Hosting;

    public class BuaAmbulanceContext : Context<BuaAmbulanceContext, BuaAmbulanceContextAttribute>
    {
        public BuaAmbulanceContext(DbContextOptions<BuaAmbulanceContext> options, IHostingEnvironment currentEnvironment) : base(options, currentEnvironment) { }

        public DbSet<BuaAmbulance> Ambulances { get; set; }

        public DbSet<Whiner> Whiners { get; set; }
    }
}
