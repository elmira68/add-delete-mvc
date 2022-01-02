using Microsoft.EntityFrameworkCore;

namespace NEW_MVC
{
  public class connect:DbContext
   {
      public DbSet<product> products { get; set; }

      public DbSet<admin> admins { get; set; }
     


     protected override void OnConfiguring(DbContextOptionsBuilder db)
     {
         db.UseSqlServer("Data Source = ELMIRA\\MSSQLSERVER2;Initial Catalog = Shop;Integrated Security=true");
     }





   } 
}