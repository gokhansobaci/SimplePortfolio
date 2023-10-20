using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelWebSite.Models
{
    public class IndexViewModel
    {
        public IEnumerable<ExperienceModel> Experiences { get; set; }
        public IEnumerable<EducationModel> Educations { get; set; }
        public IEnumerable<AwardModel> Awards { get; set; }
        public IEnumerable<SkillModel> Skills { get; set; }
        public IEnumerable<WorkflowModel> Workflows { get; set; }

        public IndexViewModel()
        {
            //Null hatalarını engellemek için var.
            Educations = new HashSet<EducationModel>();
            Experiences = new HashSet<ExperienceModel>();
            Awards = new HashSet<AwardModel>();
            Skills = new HashSet<SkillModel>();
            Workflows = new HashSet<WorkflowModel>();
        }
    }
}