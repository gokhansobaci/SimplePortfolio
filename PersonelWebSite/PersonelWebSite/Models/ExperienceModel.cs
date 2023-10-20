using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PersonelWebSite.Models
{
    [Table("experiences")]
    public class ExperienceModel
    {
        [Key]
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Detail { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}