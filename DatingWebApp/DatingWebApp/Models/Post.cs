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

        [Display(Name = "Text")]
        [Required(ErrorMessage = "Du måste skriva något i inlägget")]
        public string Text { get; set; }

        public DateTime DateTime { get; set; }

        //public int Wall_Id { get; set; }
        //[ForeignKey("Wall_Id")]
        //public Wall Wall { get; set; }

        //public int Profile_Id { get; set; }
        //[ForeignKey("Profile_Id")]
        //public virtual Profile Profile { get; set; }
    }
}