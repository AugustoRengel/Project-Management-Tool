using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Tool.Classes
{
    internal class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Owner { get; set; }
        public string Tags { get; set; }
        public string Members { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime LastModification { get; set; }
    }
}
