using Microsoft.EntityFrameworkCore;
using ToDoList.Data;


namespace ToDoList.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ToDoListDbContext _context;

        public TaskRepository(ToDoListDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TaskEntity task)
        {
           await _context.Tasks.AddAsync(task);

        }

        public async void DeleteAsync(TaskEntity task)
        {
           _context.Remove(task);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TaskEntity>> GetAllAsync()
        {
            return await _context.Tasks.ToListAsync();
          
        }

        public async Task<TaskEntity?> GetByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }


        public async void UpdateAsync(TaskEntity task)
        {
            _context.Update(task);
            await _context.SaveChangesAsync();
        }
    }
}
