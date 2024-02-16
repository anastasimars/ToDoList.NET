using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList
{
    public class Task
    {
        public long Id { get; set; }
        [Column("task_title")]
        public string TaskTitle { get; set; }
        [Column("task_description")]
        public string Description { get; set; }
        public DateTime Deadline { get; set; }

        public bool Status { get; set; }
        public ICollection<Subtask> Subtasks { get; set; } 
            = new HashSet<Subtask>();

        public Task(string TaskTitle, string Description, 
            DateTime Deadline, bool Status) {
            this.TaskTitle = TaskTitle;
            this.Description = Description;
            this.Deadline = Deadline;
            this.Status = Status;
        
        }
    }
}
