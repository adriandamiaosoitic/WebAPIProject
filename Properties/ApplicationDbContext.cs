using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext { // Classe padrao do .NET
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Director> Directors { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ 

    }

}