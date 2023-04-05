using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_App_Final_Project
{
    public partial class Task_Info_Form : Form
    {
        private Task _newTask;
        public Task_Info_Form()
        {
            InitializeComponent();
        }

        private void buttonAddInfo_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text != "" && textBoxDes.Text != "")
            {
                string title = textBoxTitle.Text;
                string description = textBoxDes.Text;
                DateTime dateTime = dateTimePickerDate.Value;


                _newTask = new Task(title, description, dateTime);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("กรุณาใส่ข้อมูลให้ครบถ้วน");
            }

        }
        public Task GetTask()
        {
            return _newTask;
        }
    }
}
