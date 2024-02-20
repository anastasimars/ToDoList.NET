using ToDoList.DTOs;

namespace ToDoList.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskEntity>> GetAllAsync();
        Task<TaskEntity?> GetByIdAsync(int id);
        Task AddAsync(TaskEntity task);
        void UpdateAsync(TaskEntity task);
        void DeleteAsync(TaskEntity task);
    }
}
