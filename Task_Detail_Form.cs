using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace To_Do_App_Final_Project
{
    public partial class Task_Detail_Form : Form
    {
        public Task_Detail_Form()
        {
            InitializeComponent();
        }
        public Task_Detail_Form(string title, string descrip, string DueDate)
        {
            InitializeComponent();
            Detail(title, descrip, DueDate);
        }

        private void Detail(string title, string descrip, string DueDate)
        {
            textBox1.Text = title;
            textBox2.Text = descrip;
            textBox3.Text = DueDate;
        }
        private void buttonBackDetail_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
