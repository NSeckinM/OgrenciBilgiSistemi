using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OgrenciBilgiSistemi.Identity

{
    public class ApplicationIdentityDbContext: IdentityDbContext<Kullanici>
    {

        public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options) : base(options)
        {
        }

    }
}
