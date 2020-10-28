
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.EnterpriseServices;

namespace EF_MVC_RF.Models
{
    public class Course
    {
        //tribute lets you enter the primary key for the course rather than having the database generate it.
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // navigation prop
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}