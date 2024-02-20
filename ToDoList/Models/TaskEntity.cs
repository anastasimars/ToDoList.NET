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
            = new List<SubtaskEntity>();

        public TaskEntity(string TaskTitle, 
            string TaskDescription, 
            DateTime Deadline, 
            bool Status, 
            ICollection<SubtaskEntity> Subtasks) 
        {
            this.TaskTitle = TaskTitle;
            this.TaskDescription = TaskDescription;
            this.Deadline = Deadline;
            this.Status = Status;
            this.Subtasks = Subtasks ?? new List<SubtaskEntity>();
        }

        public TaskEntity()
        {
        }
    }
}
