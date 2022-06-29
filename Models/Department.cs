using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Task12PatternAndRelatedDataLoading.Models;

namespace Task11PatternAndRelatedDataLoading.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        public University University { get; set; }
        public int UniversityId { get; set; }

        private ICollection<Student> _StudentsInDept;
        public ICollection<Student> StudentsInDept
        {
            get => LazyLoader.Load(this, ref _StudentsInDept);
            set => _StudentsInDept = value;
        }


        private ILazyLoader LazyLoader { get; set; }
        public Department(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }
        public Department()
        {

        }
    }
}
