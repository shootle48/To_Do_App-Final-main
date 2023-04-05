using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace To_Do_App_Final_Project
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public Task(string title, string description, DateTime dueDate) { 
            this.Title= title;
            this.Description= description;
            this.DueDate= dueDate;
        }
    }
}




