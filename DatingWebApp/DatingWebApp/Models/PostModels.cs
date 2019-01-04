using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DatingWebApp.Models
{
    public class PostModel
    {
        [Key]
        public int Post_ID { get; set; }
        public string Text { get; set; }
        public DateTime PostDate { get; set; }

        public ProfileModel Sender { get; set; }
        public ProfileModel Receiver { get; set; }
    }
}