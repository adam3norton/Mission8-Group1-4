using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8_Group1_4.Models
{
    public class TaskList
    {
        [Key]
        [Required(ErrorMessage = "Please provide a value for ID.")]
        public int TaskId { get; set; }

        [Required(ErrorMessage = "Please provide a value for Title.")]
        public string Title { get; set; }

        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Please provide a value for Quadrant.")]
        public int Quadrant { get; set; }

        [Required(ErrorMessage = "Please provide a value for Category.")]
        public int CategoryId{ get; set; }

        public Category Category { get; set; }

        [Required(ErrorMessage = "Please provide a value for Completed.")]
        public bool Completed { get; set; }
    }
}
