﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annexus_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string Role { get; set; }

    }
}
