using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppPiagetLalis.Models;

namespace WebAppPiagetLalis.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<WebAppPiagetLalis.Models.Aluno> Aluno { get; set; } = default!;

public DbSet<WebAppPiagetLalis.Models.Professor> Professor { get; set; } = default!;
}
