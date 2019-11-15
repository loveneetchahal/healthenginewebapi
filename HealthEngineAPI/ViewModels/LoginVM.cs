﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthEngineAPI.ViewModels
{
    public class LoginVM
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class VerifyOTP
    {
        public string UserID { get; set; }
        public string OTP { get; set; }
    }
}
