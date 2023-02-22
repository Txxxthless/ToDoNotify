using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoNotify 
{
    internal class ViewModel
    {
        public List<Objective> objectives = new List<Objective>();
        public ListBox? listOfObjectives;   

        public void DoChecking()
        {
            while (true)
            {
                foreach (Objective o in objectives)
                {
                    if ((o.objectiveTime - DateTime.Now).Milliseconds <= 0)
                    {
                        int index = objectives.IndexOf(o);
                        listOfObjectives.Items.RemoveAt(index);
                        objectives.RemoveAt(index);
                    }
                }
            }
        }
    
    }
}
