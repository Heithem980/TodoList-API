using System.ComponentModel.DataAnnotations;

namespace TodoList.API.Models
{
    public class Todo
    {

        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }
        public bool isCompleted { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? CompletedAt { get; set; }




    }
}
