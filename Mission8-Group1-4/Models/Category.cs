using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8_Group1_4.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "Please provide a value for CategoryID.")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please provide a value for Category Title.")]
        public string Title { get; set; }
    }
}
