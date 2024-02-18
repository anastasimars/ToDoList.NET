using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList
{
    public class TaskEntity
    {
        public long Id { get; set; }
        [Column("task_title")]
        public string TaskTitle { get; set; }
        [Column("task_description")]
        public string TaskDescription { get; set; }
        public DateTime Deadline { get; set; }

        public bool Status { get; set; }
        public ICollection<SubtaskEntity> Subtasks { get; set; } 
            = new HashSet<SubtaskEntity>();

        public TaskEntity(string TaskTitle, string Description, 
            DateTime Deadline, bool Status) {
            this.TaskTitle = TaskTitle;
            this.TaskDescription = Description;
            this.Deadline = Deadline;
            this.Status = Status;
        
        }
    }
}
