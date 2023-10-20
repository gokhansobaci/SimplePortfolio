using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace PersonelWebSite.Models
{
    [Table("awards")]
    public class AwardModel
    {
        [Key] // İf we don't write the key . don't be anything. here is it that attend the id primary key
        public int Id { get; set; }
        public string Title { get; set; }



    }
}