using SoftUniBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SoftUniBook.Models
{
    public class Post
    {
        public Post()
        {
            this.Date = DateTime.Now;
            this.Comments = new HashSet<Comment>();
            this.Tags = new HashSet<Tag>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name ="Заглавие")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Съдържание")]
        public string Body { get; set; }
        
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
        public bool IsAuthor(string authorId)
        {
            return this.AuthorId == authorId;
        }
        public virtual Category Category { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}