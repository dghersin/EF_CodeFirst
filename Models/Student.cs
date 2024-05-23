using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
