﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Dtos
{
    public class UserForLoginDto
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
