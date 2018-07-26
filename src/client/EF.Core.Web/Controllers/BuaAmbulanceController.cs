namespace EF.Core.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using EF.Core.Contexts.Contexts;
    using EF.Core.Entities;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    [Produces("application/json")]
    [Route("api/BuaAmbulance")]
    public class BuaAmbulanceController : Controller
    {
        private readonly BuaAmbulanceContext _context;

        public BuaAmbulanceController(BuaAmbulanceContext context)
        {
            this._context = context;
        }
        // GET: api/BuaAmbulance
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var buaAmbulances = await this._context.Ambulances.Select(b => new { b.Id, Whiners = b.Whiners.Select(w => new { w.Id, w.Name }) }).ToListAsync();
            return this.Ok(buaAmbulances);
        }

        // GET: api/BuaAmbulance/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var buaAmbulance = await this._context.Ambulances.FirstOrDefaultAsync(b => b.Id == id);

            if (buaAmbulance == null) return this.NotFound();

            return this.Ok(new { buaAmbulance.Id, Whiners = buaAmbulance.Whiners.Select(w => new { w.Id, w.Name }) });
        }

        // POST: api/BuaAmbulance
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var buaAmbulance = new BuaAmbulance { Id = Guid.NewGuid() };

            await this._context.Ambulances.AddAsync(buaAmbulance);
            await this._context.SaveChangesAsync();

            return this.Ok(new { Id = buaAmbulance.Id });
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var buaAmbulance = await this._context.Ambulances.FirstOrDefaultAsync(b => b.Id == id);

            if (buaAmbulance == null) return this.NotFound();
            this._context.Ambulances.Remove(buaAmbulance);
            await this._context.SaveChangesAsync();

            return this.Ok(new { Id = buaAmbulance.Id });
        }
    }
}
