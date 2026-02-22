using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestionTaller.API.Persistence;

public class GestionTallerDbContext:IdentityDbContext<IdentityUser>
{
    public GestionTallerDbContext(DbContextOptions options):base(options)
    {
        
    }
}
