﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TeamLeader : IWorker
    {

        public string LastName { get; set; }
        public string Name { get; set; }
        public TeamLeader(  string lastName, string name)
        {
            
            LastName = lastName;
            Name = name;
        }
    }
}
