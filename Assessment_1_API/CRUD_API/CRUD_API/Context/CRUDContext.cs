using CRUD_API.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_API.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext>options): base(options) 
        {

        }    
        public DbSet<Category> Categories { get; set; }
    }
}
