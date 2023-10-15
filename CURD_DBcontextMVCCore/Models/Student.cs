using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CURD_DBcontextMVCCore.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,5)]
        public int SClass { get; set; }
        [Required]
        public DateTime BirthDate{ get;set;}
        [Required]
        public int Mark { get; set; }
    }
}
