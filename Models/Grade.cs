using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        [Required]
        [StringLength(50)]
        public string GradeName { get; set; }
        [StringLength(10)]
        public string Section { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
