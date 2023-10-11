﻿using System.ComponentModel.DataAnnotations;
using API.Extensions;

namespace API.Entities{
    public class AppUser
    {
        [Key]
        public int UserId { get; set; }
        public string UserName {get; set;}
        public byte[] PasswordHash {get; set;}
        public byte[] PasswordSalt {get; set;}
        public DateTime DateOfBirth {get; set;}
        public string KnownAs {get; set;}
        public string Gender {get; set;}
        public string Introduction {get; set;}
        public string LookingFor {get; set;}
        public string Interests {get; set;}
        public string City {get; set;}
        public string Country {get; set;}
        public List<Photo> Photos {get; set;} = new();
        public DateTime CreatedOn {get; set;} = DateTime.UtcNow;
        public DateTime LastActive {get; set;} = DateTime.UtcNow;

        public List<UserLike> LikedByUsers { get; set; }
        public List<UserLike> LikedUsers { get; set; }
    }
}


