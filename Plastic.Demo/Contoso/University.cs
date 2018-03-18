using Plastic.Definitions;
using Plastic.Definitions.Data;
using Plastic.Definitions.Enumerations;

namespace Plastic.Demo.Contoso
{
    public class University
    {
        public static ApplicationDefinition Create()
        {
            ApplicationDefinition application = new ApplicationDefinition
            {
                Namespace = "ContosoUniversity"
            };

            DatabaseDefinition database = new DatabaseDefinition
            {
                Name = "School"
            };

            application.Databases.Add(database);

            database.AddTable(CourseTableDefinition());
            database.AddTable(DepartmentTableDefinition());
            database.AddTable(EnrollmentTableDefinition());
            database.AddTable(InstructorTableDefinition());
            database.AddTable(OfficeAssignmentTableDefinition());
            database.AddTable(PersonTableDefinition());
            database.AddTable(StudentTableDefinition());

            application.Enumerations.Add(GradeDefinition());

            return application;
        }

        private static EnumerationDefinition GradeDefinition()
        {
            EnumerationDefinition grade = new EnumerationDefinition("Grade");

            grade.AddValue("A");
            grade.AddValue("B");
            grade.AddValue("C");
            grade.AddValue("D");
            grade.AddValue("E");
            grade.AddValue("F");
            return grade;
        }

        private static TableDefinition PersonTableDefinition()
        {
            TableDefinition table = new TableDefinition("Person")
            {
                Plural = "People",
                Abstract = true,
                DisplayName = "Person"
            };
            table.AddField(new IntFieldDefinition("ID")
            {
                Key = 1,
            });

            table.AddField(new StringFieldDefinition("LastName")
            {
                Required = true,
                Length = 50,
                DisplayName = "Last name"
            });

            table.AddField(new StringFieldDefinition("FirstMidName")
            {
                Required = true,
                Length = 50,
                LengthErrorMessage = "First name cannot be longer than 50 characters.",
                DisplayName = "First Name",
                ColumnName = "FirstName"
            });

            table.AddField(new CalculatedFieldDefinition("FullName")
            {
                DisplayName = "Full Name"
            });

            return table;
        }

        private static TableDefinition StudentTableDefinition()
        {
            TableDefinition table = new TableDefinition("Student")
            {
                ParentTable = "Person",
                Plural = "Students",
                Abstract = false,
                DisplayName = "Student"
            };
            table.AddField(new DateTimeFieldDefinition("EnrollmentDate")
            {
                Required = true,
                Type = DateTimeType.Date,
                DisplayName = "Enrollment Date"
            });

            return table;
        }

        private static TableDefinition InstructorTableDefinition()
        {
            TableDefinition table = new TableDefinition("Instructor")
            {
                ParentTable = "Person",
                Plural = "Instructors",
                Abstract = false,
                DisplayName = "Instructor"
            };
            table.AddField(new DateTimeFieldDefinition("HireDate")
            {
                Required = true,
                Type = DateTimeType.Date,
                DisplayName = "Hire Date"
            });

            table.AddField(new MultipleFieldDefinition("Courses")
            {
                ParentTable = "Courses"
            });
            table.AddField(new ParentFieldDefinition("OfficeAssignment")
            {
                ParentTable = "OfficeAssignment"
            });

            return table;
        }

        private static TableDefinition CourseTableDefinition()
        {
            TableDefinition table = new TableDefinition("Course")
            {
                Plural = "Courses"
            };
            table.AddField(new IntFieldDefinition("CourseID")
            {
                Key = 1,
                DisplayName = "Number"
            });
            table.AddField(new StringFieldDefinition("Title")
            {
                Length = 50,
                MinimumLength = 3
            });
            table.AddField(new IntFieldDefinition("Credits")
            {
                Minimum = 0,
                Maximum = 5
            });
            table.AddField(new ParentFieldDefinition("Department")
            {
                ParentTable = "Department"
            });

            return table;
        }

        private static TableDefinition DepartmentTableDefinition()
        {
            TableDefinition table = new TableDefinition("Department")
            {
                Plural = "Departments"
            };

            table.AddField(new IntFieldDefinition("DepartmentID")
            {
                Key = 1
            });

            table.AddField(new StringFieldDefinition("Name")
            {
                Length = 50,
                MinimumLength = 3
            });

            table.AddField(new DecimalFieldDefinition("Budget")
            {
                Type = NumberType.Currency
            });

            table.AddField(new DateTimeFieldDefinition("StartDate")
            {
                Type = DateTimeType.Date,
                DisplayName = "Start Date"
            });
            table.AddField(new ParentFieldDefinition("Administrator")
            {
                ParentTable = "Instructor"
            });

            return table;
        }

        private static TableDefinition EnrollmentTableDefinition()
        {
            TableDefinition table = new TableDefinition("Enrollment")
            {
                Plural = "Enrollments"
            };

            table.AddField(new IntFieldDefinition("EnrollmentID")
            {
                Key = 1
            });

            EnumerationFieldDefinition grade = table.AddField(new EnumerationFieldDefinition("Grade")
            {
                EmptyText = "No Grade",
                EnumerationName = "Grade"
            });
            table.AddField(new ParentFieldDefinition("Course")
            {
                ParentTable = "Course"
            });
            table.AddField(new ParentFieldDefinition("Student")
            {
                ParentTable = "Student"
            });

            return table;
        }

        private static TableDefinition OfficeAssignmentTableDefinition()
        {
            TableDefinition table = new TableDefinition("OfficeAssignment")
            {
                Plural = "OfficeAssignments"
            };

            table.AddField(new ParentFieldDefinition("Instructor")
            {
                Key = 1,
                ParentTable = "Instructor"
            });

            table.AddField(new StringFieldDefinition("Name")
            {
                Length = 50,
                DisplayName = "Office Location"
            });
            
            return table;
        }
    }
}