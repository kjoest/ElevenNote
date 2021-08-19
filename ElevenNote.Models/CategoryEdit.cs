using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryEdit
    {
        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        [Display(Name = "CategoryName")]
        public string CategoryName { get; set; }
    }
}
