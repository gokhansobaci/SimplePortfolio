using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PersonelWebSite.Models
{
    [Table("educations")]
    public class EducationModel
    {
        [Key]
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string ProgramTitle { get; set; }
        public string Detail { get; set; }
        public double GPA { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}