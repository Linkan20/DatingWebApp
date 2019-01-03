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

        public int Requester { get; set; }

        public int Receiver { get; set; }

        public bool Accepted
        {
            get { return Accepted; }
            set { Accepted = false; }
        }
    }
}