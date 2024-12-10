using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Toturials.Models
{
    public class AppDbContext : DbContext
    {
       
            public DbSet<User> Users { get; set; }

            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
                Users = Set<User>();
            }
        

        // Ajoutez des DbSet pour chaque modèle que vous souhaitez stocker dans la base de données
      
    }
}
