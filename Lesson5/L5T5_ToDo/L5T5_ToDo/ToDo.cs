using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5T5_ToDo
{
    class ToDo
    {
        public string Title { get; set; }
        public bool isDone { get; set; }

        public ToDo(string name, bool state = false) 
        {
            Title = name;
            isDone = state;
        }

        public ToDo()
        {
            Title = "";
            isDone = false;
        }

        public void DoIt()
        {
            this.isDone = true;
        }

        public void printTask() 
        {
            var pref = isDone ? "[x]" : "[ ]" ;
            Console.WriteLine($"{pref} {Title}");
        }

    }
}
