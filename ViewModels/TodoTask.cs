using TodoList.Enums;

namespace TodoList.ViewModels
{
  public class TodoTask
    {
        public  Guid Id { get; set; }
        public required string Title { get; set; }
        public DateTime CreatedAt { get; set;}
        public DateTime? FinishedAt { get; set;}
        public StatusEnum Status { get; set; }

        public TodoTask()
        {
          Id = Guid.NewGuid();
        }
        
    }
}