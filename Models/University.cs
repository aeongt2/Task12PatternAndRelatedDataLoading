using System.ComponentModel.DataAnnotations;

namespace Task12PatternAndRelatedDataLoading.Models
{
    public class University
    {
        public int Id { get; set; }
        [Required]
        public string UniversityName { get; set; }
    }
}
