using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class StudentsMetaData
    {
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Enrollment Date")]
        public Nullable<System.DateTime> EnrollmentDate { get; set; }
        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Date Of Birth")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }
    }
    //the below partial class is created because of to access the data of entity model classes validations with user defined class ex.StudentsMetaData class
    //for Students entity model classes
    [MetadataType(typeof(StudentsMetaData))]
    public partial class Student { }
}