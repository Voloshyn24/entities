﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  IEnumerable<Player> Players { get; set; }
    }
}