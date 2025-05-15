using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList2
{
    public class clsToDoList
    {
        public string Name { get; set; }
        public DateTime Date_time { get; set; }
        public bool Done { get; set; }

        public static List<clsToDoList> toDoList = new List<clsToDoList>();
    }
}
