using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class Student
    {
        // ID or classnameID is the default primary key
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // is a navigation property and is virtual for lazy loading support
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}