using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PersonelWebSite.Models
{
    [Table("workflows")]
    public class WorkflowModel
    {
        [Key]
        public int Id { get; set; }
        public string FlowTitle { get; set; }
    }
}