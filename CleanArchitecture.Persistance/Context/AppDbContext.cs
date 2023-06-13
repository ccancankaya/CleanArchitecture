using CleanArchitecture.Domain.AppEntities;
using CleanArchitecture.Domain.AppEntities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistance.Context
{
    public class AppDbContext:IdentityDbContext<AppUser,AppRole,string>
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<UserAndCompanyRelation> UserAndCompanyRelations { get; set; }



    }
}
