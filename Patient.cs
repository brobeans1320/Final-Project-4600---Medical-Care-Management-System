﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_4600___Medical_Care_Management_System
{
    public class Patient : Person
    {
        private int accessLevel;
        public Patient()
        {
            this.accessLevel = 1;
        }
    }
}
