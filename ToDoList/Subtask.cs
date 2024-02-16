using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList
{
    public class Subtask
    {
        public long Id { get; set; }
        [Column("subtask_title")]
        public string SubtaskTitle { get; set; }
        public bool Status { get; set; }
        public long TaskId { get; set; }
        [ForeignKey("TaskId")]
        public Task Task { get; set; }
        
        public Subtask(string SubtaskTitle, bool Status,
            Task task) {
            ArgumentNullException.ThrowIfNull(task);
            this.SubtaskTitle = SubtaskTitle;
            this.Status = Status;
            this.Task = task;
            this.TaskId = task.Id;
        }
    }
}
