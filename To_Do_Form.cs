using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Windows.Forms;

namespace To_Do_App_Final_Project
{
    public partial class To_Do_Form : Form
    {
        To_Do_Controller controller;
        private List<Task> tasks = new List<Task>();
        Task selectedTask;
        public To_Do_Form()
        {
            InitializeComponent();
            controller = new To_Do_Controller();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV|*.csv|TEXT|*.txt";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                {
                    foreach (Task item in tasks)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2}",
                            item.Title,
                            item.Description,
                            item.DueDate.ToString()
                            ));
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV|*.csv|TEXT|*.txt";
            openFileDialog.ShowDialog();
            using (StreamReader reader = new StreamReader(openFileDialog.FileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    if (line.Length >= 3)
                    {
                        Task listTask = new Task(
                            line[0],
                            line[1],
                            DateTime.Parse(line[2])
                            );
                        tasks.Add(listTask);
                    }
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tasks;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Task_Info_Form task_Info = new Task_Info_Form();
            task_Info.ShowDialog();

            if (task_Info.DialogResult == DialogResult.OK)
            {
                Task task = task_Info.GetTask();
                tasks.Add(task);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tasks;
                dataGridView1.Columns[2].DefaultCellStyle.Format = "dddd, dd MMMM yyyy";
                task_Info.Close();
            }

        }

        private void buttonDetail_Click_1(object sender, EventArgs e)
        {
            Task_Detail_Form task_Detail = new Task_Detail_Form(selectedTask.Title, selectedTask.Description, selectedTask.DueDate.ToString("dddd, dd MMMM yyyy"));
            task_Detail.ShowDialog();

        }
        public Task getSelectedTask() { return selectedTask; }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedTask = (Task)row.DataBoundItem;
                string iTitle = selectedTask.Title;
                string iDescip = selectedTask.Description;
                DateTime iDue = selectedTask.DueDate;

                selectedTask = new Task(iTitle, iDescip, iDue);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                tasks.Clear();
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }
    }
}