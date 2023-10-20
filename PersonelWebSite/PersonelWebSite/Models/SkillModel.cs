using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelWebSite.Models
{
    public class SkillModel
    {
        [Key]
        public int Id { get; set; }
        public string SkillName { get; set; }
        public string Icon { get; set; }
    }
}