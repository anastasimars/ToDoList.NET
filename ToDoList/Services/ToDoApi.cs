using ToDoList.DTOs;

namespace ToDoList.Services
{
    public interface IToDoApi
    {
        List<TaskDto> GetAllTasks();
        TaskDto GetTaskById(int id);
        TaskDto GetTaskByTitle(string title);
        void AddTask(TaskDto taskDTO);
        void UpdateTask(TaskDto taskDTO, long id);
        void DeleteTask(long id);
        TaskDto MarkTaskAsCompleted(long taskId);
        List<SubtaskDto> GetAllSubtasksByTaskId(long taskId);
        void AddSubtask(long taskId, SubtaskDto subtaskDTO);
        void EditSubtask(long  taskId, long subtaskId, SubtaskDto subtaskDTO);
        void DeleteSubtask(long taskId, long subtaskId);
        SubtaskEntity MarkSubtaskAsCompleted(long taskId, long subtaskId);
    }
}
