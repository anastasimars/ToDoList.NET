using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList
{
    public class SubtaskEntity
    {
        public long Id { get; set; }
        [Column("subtask_title")]
        public string SubtaskTitle { get; set; }
        public bool Status { get; set; }
        public long TaskId { get; set; }
        [ForeignKey("TaskId")]
        public TaskEntity Task { get; set; }
        
        public SubtaskEntity(string SubtaskTitle, bool Status,
            TaskEntity task) {
            ArgumentNullException.ThrowIfNull(task);
            this.SubtaskTitle = SubtaskTitle;
            this.Status = Status;
            this.Task = task;
            this.TaskId = task.Id;
        }
    }
}
