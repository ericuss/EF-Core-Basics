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
    [Route("api/Whiners")]
    public class WhinerController : Controller
    {
        private readonly BuaAmbulanceContext _context;

        public WhinerController(BuaAmbulanceContext context)
        {
            this._context = context;
        }
        // GET: api/Whiner
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var whiners = await this._context.Whiners.Select(w => new { w.Id, w.Name }).ToListAsync();
            return this.Ok(whiners);
        }

        // GET: api/Whiner/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var whiner = await this._context.Whiners.FirstOrDefaultAsync(b => b.Id == id);

            if (whiner == null) return this.NotFound();

            return this.Ok(new { whiner.Id, whiner.Name });
        }

        // POST: api/Whiner
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var whiner = new Whiner { Id = Guid.NewGuid() };

            await this._context.Whiners.AddAsync(whiner);
            await this._context.SaveChangesAsync();

            return this.Ok(new { Id = whiner.Id });
        }


        [HttpPut]
        public async Task<IActionResult> Put(Guid id, [FromBody] string name)
        {
            var whiners = await this._context.Whiners.FirstOrDefaultAsync(b => b.Id == id);
            whiners.Name = name;

            this._context.Whiners.Update(whiners);
            await this._context.SaveChangesAsync();

            return this.Ok(new { Id = whiners.Id });
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var whiner = await this._context.Whiners.FirstOrDefaultAsync(b => b.Id == id);

            if (whiner == null) return this.NotFound();
            this._context.Whiners.Remove(whiner);
            await this._context.SaveChangesAsync();

            return this.Ok(new { Id = whiner.Id });
        }
    }
}
