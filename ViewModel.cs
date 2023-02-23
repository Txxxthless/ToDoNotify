using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoNotify 
{
    internal class ViewModel
    {
        public List<Objective>? objectives = new List<Objective>();
        public Form1? mainForm;

        public void DoChecking()
        {
            while (true)
            {
                Thread.Sleep(1000);
                foreach (var o in objectives)
                {
                    if (DateTime.Now.CompareTo(o.objectiveTime) >= 0 && mainForm is not null)
                    {
                        mainForm.Invoke(mainForm.DeleteFromListBox, new Object[] { objectives.IndexOf(o) });
                        objectives.Remove(o);
                        break;
                    }
                }
            }
        }
    }
}
