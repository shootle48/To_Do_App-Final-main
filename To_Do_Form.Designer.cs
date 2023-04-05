namespace To_Do_App_Final_Project
{
    partial class To_Do_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            taskBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            ไฟลToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ColumnTitle = new DataGridViewTextBoxColumn();
            ColumnDes = new DataGridViewTextBoxColumn();
            ColumnDue = new DataGridViewTextBoxColumn();
            buttonAdd = new Button();
            buttonDetail = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // taskBindingSource
            // 
            taskBindingSource.DataSource = typeof(Task);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ไฟลToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1593, 35);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // ไฟลToolStripMenuItem
            // 
            ไฟลToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            ไฟลToolStripMenuItem.Name = "ไฟลToolStripMenuItem";
            ไฟลToolStripMenuItem.Size = new Size(57, 29);
            ไฟลToolStripMenuItem.Text = "ไฟล์";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(156, 34);
            openToolStripMenuItem.Text = "เปิด";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(156, 34);
            saveToolStripMenuItem.Text = "บันทึก";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("TH Baijam", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(0, 40);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(443, 116);
            label4.TabIndex = 7;
            label4.Text = "TO DO LIST";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.LightBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("TH Baijam", 20.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnTitle, ColumnDes, ColumnDue });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(0, 155);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1346, 798);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // ColumnTitle
            // 
            ColumnTitle.DataPropertyName = "title";
            ColumnTitle.HeaderText = "ชื่อ";
            ColumnTitle.MinimumWidth = 8;
            ColumnTitle.Name = "ColumnTitle";
            ColumnTitle.ReadOnly = true;
            // 
            // ColumnDes
            // 
            ColumnDes.DataPropertyName = "description";
            ColumnDes.HeaderText = "เนื้อหา";
            ColumnDes.MinimumWidth = 8;
            ColumnDes.Name = "ColumnDes";
            ColumnDes.ReadOnly = true;
            // 
            // ColumnDue
            // 
            ColumnDue.DataPropertyName = "dueDate";
            ColumnDue.HeaderText = "วันครบกำหนด";
            ColumnDue.MinimumWidth = 8;
            ColumnDue.Name = "ColumnDue";
            ColumnDue.ReadOnly = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Wide Latin", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(1393, 155);
            buttonAdd.Margin = new Padding(4, 5, 4, 5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 142);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDetail
            // 
            buttonDetail.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDetail.Location = new Point(1373, 363);
            buttonDetail.Margin = new Padding(4, 5, 4, 5);
            buttonDetail.Name = "buttonDetail";
            buttonDetail.Size = new Size(189, 92);
            buttonDetail.TabIndex = 9;
            buttonDetail.Text = "ดูรายละเอียด";
            buttonDetail.UseVisualStyleBackColor = true;
            buttonDetail.Click += buttonDetail_Click_1;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(1373, 510);
            buttonDelete.Margin = new Padding(4, 5, 4, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(189, 92);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "ลบข้อมูล";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // To_Do_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1593, 938);
            Controls.Add(buttonDelete);
            Controls.Add(buttonDetail);
            Controls.Add(buttonAdd);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "To_Do_Form";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ไฟลToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private BindingSource taskBindingSource;
        private Label label4;
        private DataGridView dataGridView1;
        private Button buttonAdd;
        private DataGridViewTextBoxColumn ColumnTitle;
        private DataGridViewTextBoxColumn ColumnDes;
        private DataGridViewTextBoxColumn ColumnDue;
        private Button buttonDetail;
        private Button buttonDelete;
    }
}