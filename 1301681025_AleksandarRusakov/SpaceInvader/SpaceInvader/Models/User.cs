using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpaceInvader.Models
{
    public class User
    {
        public Int32 Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public Int32 MaxScore { get; set; }
        public String Rank { get; set; }
    }
}