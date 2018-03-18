using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ContosoUniversity.Enumerations;

namespace ContosoUniversity.Models
{
    [GeneratedCode("","")]
    public abstract partial class Person
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Last name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [Column("FirstName")]
        [StringLength(50)]
        public string FirstMidName { get; set; }

    }
}
