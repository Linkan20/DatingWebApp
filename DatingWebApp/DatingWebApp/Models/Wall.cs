using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DatingWebApp.Models
{
    public class Wall
    {
        [Key]
        public int Wall_Id { get; set; }

        //public int Profile_Id { get; set; }
        //[ForeignKey("Profile_Id")]
        //public Profile Profile { get; set; }
    }
}