using Blog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCBlog.Models
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
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name ="Заглавие")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Съдържание")]
        public string Body { get; set; }
        
        [Required]
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        public ApplicationUser Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual IEnumerable<Tag> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}