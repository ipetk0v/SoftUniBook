using Blog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBlog.Models
{
    public class Post
    {
        public Post()
        {
            this.Date = DateTime.Now;
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
    }
}