using System.ComponentModel.DataAnnotations;

namespace TodoApp.Api
{
    public class Todo
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid? Assignee { get; set; }

        public DateTime CreatedDate { get; set; }

        public Priority Priority { get; set; }

        public Status Status { get; set; }
    }
}
