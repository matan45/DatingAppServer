﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { set; get; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "you must specify password between 4 and 8")]
        public string Password { set; get; }
        [Required]
        public string Gender { set; get; }
        [Required]
        public string KnownAs { set; get; }
        [Required]
        public DateTime DateOfBirth { set; get; }
        [Required]
        public string City { set; get; }
        [Required]
        public string Country { set; get; }
        public DateTime Created { set; get; }
        public DateTime LastActive { set; get; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}
