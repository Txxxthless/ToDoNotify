using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoNotify
{
    internal class Objective
    {
        private DateTime _objectiveTime;
        private string _objectiveDescription;

        public string TimeAndDescriptiong 
        {
            get => $"{_objectiveTime} - {_objectiveDescription}";
        }

        public Objective(DateTime d, string description)
        {
            _objectiveTime = d;  
            _objectiveDescription = description;
        }

    }
}
