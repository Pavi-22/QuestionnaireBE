﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireMW.Models
{
    public class Token
    {
        public string UserName { get; set; }
        public string token { get; set; }
        public int UserId { get; set; }
        public int UserResponse { get; set; }

    }
}
