using SoftUniBook.Models;
using System.ComponentModel.DataAnnotations;

namespace SoftUniBook.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Content { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public virtual Post Post { get; set; }
    }
}