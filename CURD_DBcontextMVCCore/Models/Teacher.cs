using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CURD_DBcontextMVCCore.Models
{
    public class Teacher
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
