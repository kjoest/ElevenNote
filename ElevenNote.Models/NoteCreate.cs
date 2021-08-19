using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Title { get; set; }

        [MaxLength(8000)]
        public string Content { get; set; }

        [Display(Name ="Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name ="Category Name")]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
