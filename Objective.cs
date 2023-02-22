﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoNotify
{
    internal class Objective
    {
        public DateTime objectiveTime;
        public string objectiveDescription;

        public string TimeAndDescription 
        {
            get => $"{objectiveTime}:{objectiveDescription}";
        }

        public Objective(DateTime d, string description)
        {
            objectiveTime = d;  
            objectiveDescription = description;
        }

    }
}
