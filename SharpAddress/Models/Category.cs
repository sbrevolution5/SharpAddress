using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SharpAddress.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        [Display(Name = "Category Description")]
        public string CategoryDescription { get; set; }
        [Display(Name = "Category Image")]
        public byte[] CategoryImage { get; set; }
        public string ContentType { get; set; }
        public ICollection<Contact> ContactList { get; set; } = new HashSet<Contact>();
    }
}
