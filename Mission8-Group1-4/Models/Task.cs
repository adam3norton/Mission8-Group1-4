using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8_Group1_4.Models
{
    public class Task
    {
        [Key]
        [Required]
        public int TaskId { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime DueDate { get; set; }

        [Required]
        public int Quadrant { get; set; }

        [Required]
        public int CategoryId{ get; set; }

        public Category Category { get; set; }

        [Required]
        public bool Completed { get; set; }
    }
}
