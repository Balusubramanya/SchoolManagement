using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class CoursesMetaData
    {
        [StringLength(50)]
        [Display (Name ="Course Titles")]
        public string Title { get; set; }
        [Range(1,8)]
        [Display(Name = "Course Credits")]
        public int Credits { get; set; }
    }
    //the below partial class is created because of to access the data of entity model classes validations with user defined class ex.CoursesMetaData class
    //for Courses entity model classes
    [MetadataType(typeof(CoursesMetaData))]
    public partial class Course
    {

    }
}