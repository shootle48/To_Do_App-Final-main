namespace To_Do_App_Final_Project
{
    partial class Task_Info_Form
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
            dateTimePickerDate = new DateTimePicker();
            buttonAddInfo = new Button();
            textBoxDes = new TextBox();
            textBoxTitle = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1, 710);
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
            label2.Location = new Point(30, 152);
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
            label1.Location = new Point(71, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 44);
            label1.TabIndex = 28;
            label1.Text = "รายการ";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDate.Location = new Point(181, 710);
            dateTimePickerDate.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(284, 51);
            dateTimePickerDate.TabIndex = 27;
            // 
            // buttonAddInfo
            // 
            buttonAddInfo.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddInfo.Location = new Point(476, 713);
            buttonAddInfo.Margin = new Padding(4, 5, 4, 5);
            buttonAddInfo.Name = "buttonAddInfo";
            buttonAddInfo.Size = new Size(201, 53);
            buttonAddInfo.TabIndex = 26;
            buttonAddInfo.Text = "เพิ่มข้อมูล";
            buttonAddInfo.UseVisualStyleBackColor = true;
            buttonAddInfo.Click += buttonAddInfo_Click;
            // 
            // textBoxDes
            // 
            textBoxDes.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDes.Location = new Point(181, 152);
            textBoxDes.Margin = new Padding(4, 5, 4, 5);
            textBoxDes.Multiline = true;
            textBoxDes.Name = "textBoxDes";
            textBoxDes.Size = new Size(494, 546);
            textBoxDes.TabIndex = 25;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitle.Location = new Point(181, 87);
            textBoxTitle.Margin = new Padding(4, 5, 4, 5);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(494, 48);
            textBoxTitle.TabIndex = 24;
            // 
            // Task_Info_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 852);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerDate);
            Controls.Add(buttonAddInfo);
            Controls.Add(textBoxDes);
            Controls.Add(textBoxTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Task_Info_Form";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerDate;
        private Button buttonAddInfo;
        private TextBox textBoxDes;
        private TextBox textBoxTitle;
    }
}