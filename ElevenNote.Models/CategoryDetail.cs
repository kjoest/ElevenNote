using ElevenNote.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryDetail
    {
        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        [Display(Name = "CategoryName")]
        public string Name { get; set; }

        public ICollection<Note> Note { get; set; }
    }
}
