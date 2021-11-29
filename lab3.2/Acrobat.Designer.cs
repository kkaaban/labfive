namespace lab3._2
{
    partial class Acrobat
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
            this.panelOutputData = new System.Windows.Forms.Panel();
            this.labelOutputData = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.linkLabelChoiceFile = new System.Windows.Forms.LinkLabel();
            this.buttonDance = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonNewInNew = new System.Windows.Forms.Button();
            this.panelOutputData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOutputData
            // 
            this.panelOutputData.AutoScroll = true;
            this.panelOutputData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelOutputData.Controls.Add(this.labelOutputData);
            this.panelOutputData.Location = new System.Drawing.Point(12, 40);
            this.panelOutputData.Name = "panelOutputData";
            this.panelOutputData.Size = new System.Drawing.Size(520, 410);
            this.panelOutputData.TabIndex = 16;
            // 
            // labelOutputData
            // 
            this.labelOutputData.AutoSize = true;
            this.labelOutputData.Location = new System.Drawing.Point(13, 21);
            this.labelOutputData.Name = "labelOutputData";
            this.labelOutputData.Size = new System.Drawing.Size(299, 20);
            this.labelOutputData.TabIndex = 0;
            this.labelOutputData.Text = "выберите файл для работы с акробатами";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(125, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(94, 29);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkLabelChoiceFile
            // 
            this.linkLabelChoiceFile.AutoSize = true;
            this.linkLabelChoiceFile.Location = new System.Drawing.Point(12, 9);
            this.linkLabelChoiceFile.Name = "linkLabelChoiceFile";
            this.linkLabelChoiceFile.Size = new System.Drawing.Size(107, 20);
            this.linkLabelChoiceFile.TabIndex = 14;
            this.linkLabelChoiceFile.TabStop = true;
            this.linkLabelChoiceFile.Text = "выбрать файл";
            this.linkLabelChoiceFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChoiceFile_LinkClicked);
            // 
            // buttonDance
            // 
            this.buttonDance.Location = new System.Drawing.Point(210, 538);
            this.buttonDance.Name = "buttonDance";
            this.buttonDance.Size = new System.Drawing.Size(90, 29);
            this.buttonDance.TabIndex = 23;
            this.buttonDance.Text = "танцевать!";
            this.buttonDance.UseVisualStyleBackColor = true;
            this.buttonDance.Click += new System.EventHandler(this.buttonDance_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(18, 538);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 29);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(114, 538);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(90, 29);
            this.buttonChange.TabIndex = 21;
            this.buttonChange.Text = "изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(239, 505);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(31, 27);
            this.textBoxID.TabIndex = 20;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(18, 508);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(219, 20);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "Работа с акробатом по его ID:";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(270, 456);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(266, 29);
            this.buttonNew.TabIndex = 18;
            this.buttonNew.Text = "добавить акробата в текущий файл";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonNewInNew
            // 
            this.buttonNewInNew.Location = new System.Drawing.Point(12, 456);
            this.buttonNewInNew.Name = "buttonNewInNew";
            this.buttonNewInNew.Size = new System.Drawing.Size(258, 29);
            this.buttonNewInNew.TabIndex = 17;
            this.buttonNewInNew.Text = "создать акробата в новый файл";
            this.buttonNewInNew.UseVisualStyleBackColor = true;
            this.buttonNewInNew.Click += new System.EventHandler(this.buttonNewInNew_Click);
            // 
            // Acrobat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 576);
            this.Controls.Add(this.panelOutputData);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.linkLabelChoiceFile);
            this.Controls.Add(this.buttonDance);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonNewInNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Acrobat";
            this.Text = "Акробат";
            this.panelOutputData.ResumeLayout(false);
            this.panelOutputData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelOutputData;
        private Label labelOutputData;
        private Button buttonUpdate;
        private LinkLabel linkLabelChoiceFile;
        private Button buttonDance;
        private Button buttonDelete;
        private Button buttonChange;
        private TextBox textBoxID;
        private Label labelID;
        private Button buttonNew;
        private Button buttonNewInNew;
    }
}