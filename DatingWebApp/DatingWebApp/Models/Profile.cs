using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DatingWebApp.Models
{
    public class Profile
    {
        [Key]
        public int Profile_Id { get; set; }

        [DisplayName("Förnamn")]
        public string Firstname { get; set; }

        [DisplayName("Efternamn")]
        public string Lastname { get; set; }

        [DisplayName("Födelsedatum")]
        [DataType(DataType.Date)]
        public string Birthdate { get; set; }

        [DisplayName("Om dig själv")]
        [DataType(DataType.MultilineText)]
        public string Biography { get; set; }

        [DisplayName("Profilbild")]
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }
    }
}