namespace To_Do_App_Final_Project
{
    partial class Task_Detail_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonBackDetail = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1, 682);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 44);
            label3.TabIndex = 30;
            label3.Text = "วันครบกำหนด";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 44);
            label2.TabIndex = 29;
            label2.Text = "รายละเอียด";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 102);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 44);
            label1.TabIndex = 28;
            label1.Text = "รายการ";
            // 
            // buttonBackDetail
            // 
            buttonBackDetail.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBackDetail.Location = new Point(476, 772);
            buttonBackDetail.Margin = new Padding(4, 5, 4, 5);
            buttonBackDetail.Name = "buttonBackDetail";
            buttonBackDetail.Size = new Size(201, 53);
            buttonBackDetail.TabIndex = 26;
            buttonBackDetail.Text = "ย้อนกลับ";
            buttonBackDetail.UseVisualStyleBackColor = true;
            buttonBackDetail.Click += buttonBackDetail_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(181, 167);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(494, 502);
            textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(181, 102);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(494, 48);
            textBox1.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(181, 687);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(494, 48);
            textBox3.TabIndex = 24;
            // 
            // Task_Detail_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 852);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBackDetail);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Task_Detail_Form";
            Text = "Task_Detail_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonBackDetail;
        public TextBox textBox2;
        public TextBox textBox1;
        public TextBox textBox3;
    }
}