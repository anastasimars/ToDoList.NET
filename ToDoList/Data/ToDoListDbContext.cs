using Microsoft.EntityFrameworkCore;

namespace ToDoList.Data
{
    public class ToDoListDbContext : DbContext
    {
        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options) 
            : base(options)
        {
        }

        public DbSet<TaskEntity> Tasks { get; set; }
        public DbSet<SubtaskEntity> Subtasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubtaskEntity>()
                .HasOne(s => s.Task)
                .WithMany(t => t.Subtasks)
                .HasForeignKey(s => s.TaskId)
                .IsRequired();
        }
    }
}
