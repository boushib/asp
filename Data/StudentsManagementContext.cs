using Microsoft.EntityFrameworkCore;

namespace StudentsManagement.Data {
  public class StudentsManagementContext : DbContext
  {
    public StudentsManagementContext(DbContextOptions<StudentsManagementContext> options) : base(options)
    {
      // 
    }
    public DbSet<StudentsManagement.Models.Student > Student {get; set;}
  }
}