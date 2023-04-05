using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Windows.Forms;

namespace To_Do_App_Final_Project
{
    public class To_Do_Controller
    {
        private List<Task> _task = new List<Task>();
        public void Addtask(Task task)
        {
            this._task.Add(task);
        }
    }
}
