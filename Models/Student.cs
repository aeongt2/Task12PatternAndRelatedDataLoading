using System.ComponentModel.DataAnnotations;

namespace Task11PatternAndRelatedDataLoading.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        public int StduentAge { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}
