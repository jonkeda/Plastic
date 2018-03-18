using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ContosoUniversity.Enumerations;

namespace ContosoUniversity.Models
{
    [GeneratedCode("","")]
    public partial class Instructor : ContosoUniversity.Models.Person
    {
        [Required]
        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        public virtual ICollection<> Courses { get; set; }

        public int? OfficeAssignmentID { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }

        public virtual ICollection<Department> Departments { get; set; }

        public virtual ICollection<OfficeAssignment> OfficeAssignments { get; set; }
    }
}
