namespace ToDoList.DTOs
{
    public class SubtaskDto
    {
        public long Id { get; set; }
        public string SubtaskTitle { get; set; }
        public bool Status { get; set; }
        public long TaskId { get; set; }
    }
}
