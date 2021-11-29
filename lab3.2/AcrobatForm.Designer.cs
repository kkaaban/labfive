namespace lab3._2
{
    partial class AcrobatForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxPassID = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(12, 111);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(125, 27);
            this.textBoxType.TabIndex = 10;
            this.textBoxType.Text = "Тип акробатики";
            this.textBoxType.TextChanged += new System.EventHandler(this.textBoxType_TextChanged);
            // 
            // textBoxPassID
            // 
            this.textBoxPassID.Location = new System.Drawing.Point(12, 78);
            this.textBoxPassID.Name = "textBoxPassID";
            this.textBoxPassID.Size = new System.Drawing.Size(217, 27);
            this.textBoxPassID.TabIndex = 9;
            this.textBoxPassID.Text = "Серия и(или) номер паспорта";
            this.textBoxPassID.TextChanged += new System.EventHandler(this.textBoxPassID_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(12, 45);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(125, 27);
            this.textBoxLastName.TabIndex = 8;
            this.textBoxLastName.Text = "Фамилия";
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 12);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(125, 27);
            this.textBoxFirstName.TabIndex = 7;
            this.textBoxFirstName.Text = "Имя";
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // AcrobatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxPassID);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AcrobatForm";
            this.Text = "Заполните";
            this.Load += new System.EventHandler(this.AcrobatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBoxType;
        private TextBox textBoxPassID;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
    }
}