using Microsoft.EntityFrameworkCore;

namespace CQRS.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> context) : base(context)
        {
        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new Student(){Name="İlhan",Age=20,Surname="Daniş",Id=1},
                new Student(){Name="Rümeysa",Age=14,Surname="Daniş",Id=2},
                new Student(){Name="Ramazan",Age=50,Surname="Daniş",Id=3},
                new Student(){Name="Müşrerref",Age=44,Surname="Daniş",Id=4},
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
