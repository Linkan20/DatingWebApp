using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DatingWebApp.Models
{
    public class ProfileModel
    {
        [Key]
        public string User_ID { get; set; }

        [Display(Name= "Förnamn")]
        [Required(ErrorMessage = "Du måste ha ett förnamn.")]
        public string Firstname { get; set; }

        [Display(Name = "Efternamn")]
        [Required(ErrorMessage = "Du måste ha ett efternamn.")]
        public string Lastname { get; set; }

        [Display(Name = "Födelsedatum")]
        [Required(ErrorMessage = "Du måste ha ett födelsedatum.")]
        [DataType(DataType.Date)]
        public string Birthdate { get; set; }

        [Display(Name = "Stad")]
        [Required(ErrorMessage = "*")]
        public string City { get; set; }

        [Display(Name = "Om dig själv")]
        [DataType(DataType.MultilineText)]
        public string Biography { get; set; }

        [Display(Name = "Kön")]
        [Required(ErrorMessage = "*")]
        public string Gender { get; set; }

        [Display(Name = "Söker")]
        [Required(ErrorMessage = "*")]
        public string LookingFor { get; set; }

        [Display(Name = "Profilbild")]
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }
    }
}