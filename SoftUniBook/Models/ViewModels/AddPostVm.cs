using MVCBlog.Models;
using System.Collections.Generic;

namespace Blog.Models.ViewModels
{
    public class AddPostVm
    {
        public IEnumerable<Category> Categories { get; set; }
        public Post Post { get; set; }
    }
}