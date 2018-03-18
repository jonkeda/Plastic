using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ContosoUniversity.Enumerations;

namespace ContosoUniversity.Models
{
    [GeneratedCode("","")]
    public partial class OfficeAssignment
    {
        public int? InstructorID { get; set; }
        public virtual Instructor Instructor { get; set; }

        [Display(Name = "Office Location")]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}
