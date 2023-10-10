using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotnetAuth.Api.Data;


public class ApplicationDbUser : IdentityDbContext
{
    public ApplicationDbUser(DbContextOptions<ApplicationDbUser> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}