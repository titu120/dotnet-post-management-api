using System.ComponentModel.DataAnnotations;

namespace DotNetApiDemo.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter title")]
        public string Title { get; set; }

        [Required(ErrorMessage ="please enter description")]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
