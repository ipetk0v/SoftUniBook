using MVCBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models.ViewModels
{
    public class AddPostVm
    {
        public IEnumerable<Category> Categories { get; set; }
        public Post Post { get; set; }
    }
}