﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewApp_DAL.Models
{
    public class Perfil
    {
        public int Id { get; set; }
        public List<Skill> Skills { get; set; }
    }
}