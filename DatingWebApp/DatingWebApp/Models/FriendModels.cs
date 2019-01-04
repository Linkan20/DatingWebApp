using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatingWebApp.Models
{
    public class FriendModel
    {
        [Key]
        public int Friend_ID { get; set; }

        public ProfileModel Requester { get; set; }
        public ProfileModel Receiver { get; set; }

        public bool Accepted { get; set; }

        public FriendModel()
        {
            Accepted = false;
        }
    }
}