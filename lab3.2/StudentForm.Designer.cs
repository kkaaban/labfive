namespace lab3._2
{
    partial class StudentForm
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPassID = new System.Windows.Forms.TextBox();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 12);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(125, 27);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.Text = "Имя";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(12, 45);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(125, 27);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.Text = "Фамилия";
            // 
            // textBoxPassID
            // 
            this.textBoxPassID.Location = new System.Drawing.Point(12, 78);
            this.textBoxPassID.Name = "textBoxPassID";
            this.textBoxPassID.Size = new System.Drawing.Size(217, 27);
            this.textBoxPassID.TabIndex = 2;
            this.textBoxPassID.Text = "Серия и(или) номер паспорта";
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(12, 111);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(125, 27);
            this.textBoxCourse.TabIndex = 3;
            this.textBoxCourse.Text = "Курс";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(12, 144);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(163, 27);
            this.textBoxStudentID.TabIndex = 4;
            this.textBoxStudentID.Text = "Номер студенческого";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(12, 177);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(125, 27);
            this.textBoxCity.TabIndex = 5;
            this.textBoxCity.Text = "Город прибытия";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.textBoxPassID);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заполните";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxPassID;
        private TextBox textBoxCourse;
        private TextBox textBoxStudentID;
        private TextBox textBoxCity;
        private Button button1;
    }
}