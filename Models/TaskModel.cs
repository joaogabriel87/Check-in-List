using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Check_in_List.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateCompletion { get; set; }
        public bool IsCompleted { get; set; }
    }
}