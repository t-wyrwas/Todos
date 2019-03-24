namespace RestService.Model
{
    public class Task
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Details {get; set;}
        public TaskStatus TaskStatus {get; set;}
        public int ProjectId {get; set;}
    }
}