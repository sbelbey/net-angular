﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewApp_DAL.Models
{
    public class Usuario : Persona
    {
        public string Username { get; set; }
        public string Password { get; set; }
        //public string PasswordHash { get; set; }
        //public string PasswordSalt { get; set; }
    }
}