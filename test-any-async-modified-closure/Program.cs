using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace test_any_async_modified_closure
{
    class Entity
    {
        public Guid Id { get; set; } 
    }
    class DbContext
    {
        public DbSet<Entity> Entities { get; set; }
    }

    static class Program
    {
        private static DbContext _ctx;

        public static async Task Main()
        {
            _ctx = new DbContext();
            Guid id = new Guid();
            await _ctx.Entities.AnyAsync(x => x.Id == id);
            id = new Guid();
        }
    }
}
