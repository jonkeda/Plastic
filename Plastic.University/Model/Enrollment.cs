using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ContosoUniversity.Enumerations;

namespace ContosoUniversity.Models
{
    [GeneratedCode("","")]
    public partial class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        [DisplayFormat(NullDisplayText = "No Grade")]
        public Grade? Grade { get; set; }

        public int? CourseID { get; set; }
        public virtual Course Course { get; set; }

        public int? StudentID { get; set; }
        public virtual Student Student { get; set; }
    }
}
