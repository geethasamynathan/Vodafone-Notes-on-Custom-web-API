using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CodeFirstConfigDemo
{
    //[Table("tlStudent")]
    public class Student
    {
      //  [Column("StudentId")]
      //[Key]
        public int Id { get; set; }
       // [Required]
      //  [MaxLength(20,ErrorMessage ="Name must less than 20 chars")]
        public string Name { get; set; }
        [Range(21,70)]
        public int? Age { get; set; }
      //  [NotMapped]
      
        public string City { get; set; }
      //  [Key]
        public int stdid { get; set; }
    }
}
