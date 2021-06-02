﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILenguage.API.Resources
{
    public class SessionDetailResource
    {
        public int Id { get; set; }

        public string State { get; set; }
        public string Topic { get; set; }
        public string Information { get; set; }

        public SessionResource Session { get; set; }
    }
}