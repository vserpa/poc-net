using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    
    public class Enrollment
    {
        // ID or classnameID is the default primary key
        public int EnrollmentID { get; set; }

        // ClassnameID is a EF convention for FK
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        
        // question mark indicates a nullable value
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}