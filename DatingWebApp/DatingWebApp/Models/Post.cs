using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DatingWebApp.Models
{
    public class Post
    {
        [Key]
        public int Post_Id { get; set; }

        public string Text { get; set; }
        public DateTime DateTime { get; set; }

        public int Profile_Id { get; set; }
        [ForeignKey("Profile_Id")]
        public virtual Profile Profile { get; set; }
    }
}