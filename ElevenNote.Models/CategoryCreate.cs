using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate
    {
        [MaxLength(15, ErrorMessage = "There are to many characters in this field.")]
        public int CategoryID { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
