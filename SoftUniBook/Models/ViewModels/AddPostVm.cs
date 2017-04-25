using System.Collections.Generic;

namespace SoftUniBook.Models.ViewModels
{ 
    public class AddPostVm
    {
        public IEnumerable<Models.Category> Categories { get; set; }
        public Post Post { get; set; }
    }
}