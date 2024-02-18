namespace ToDoList.DTOs
{
    public class TaskDto
    {
        public long Id { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }

        public DateTime Deadline { get; set; }
        public bool TaskStatus { get; set; }
    }
}
