namespace lab3._2
{
    partial class Form1
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
            this.linkLabelOpenAcrobat = new System.Windows.Forms.LinkLabel();
            this.linkLabelOpenTaxiDriver = new System.Windows.Forms.LinkLabel();
            this.linkLabelChoiceFile = new System.Windows.Forms.LinkLabel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelOutputData = new System.Windows.Forms.Panel();
            this.labelOutputData = new System.Windows.Forms.Label();
            this.buttonNewInNew = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDance = new System.Windows.Forms.Button();
            this.panelOutputData.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelOpenAcrobat
            // 
            this.linkLabelOpenAcrobat.AutoSize = true;
            this.linkLabelOpenAcrobat.Location = new System.Drawing.Point(376, 10);
            this.linkLabelOpenAcrobat.Name = "linkLabelOpenAcrobat";
            this.linkLabelOpenAcrobat.Size = new System.Drawing.Size(78, 20);
            this.linkLabelOpenAcrobat.TabIndex = 0;
            this.linkLabelOpenAcrobat.TabStop = true;
            this.linkLabelOpenAcrobat.Text = "Акробаты";
            this.linkLabelOpenAcrobat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOpenAcrobat_LinkClicked);
            // 
            // linkLabelOpenTaxiDriver
            // 
            this.linkLabelOpenTaxiDriver.AutoSize = true;
            this.linkLabelOpenTaxiDriver.Location = new System.Drawing.Point(460, 10);
            this.linkLabelOpenTaxiDriver.Name = "linkLabelOpenTaxiDriver";
            this.linkLabelOpenTaxiDriver.Size = new System.Drawing.Size(72, 20);
            this.linkLabelOpenTaxiDriver.TabIndex = 1;
            this.linkLabelOpenTaxiDriver.TabStop = true;
            this.linkLabelOpenTaxiDriver.Text = "Таксисты";
            this.linkLabelOpenTaxiDriver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOpenTaxiDriver_LinkClicked);
            // 
            // linkLabelChoiceFile
            // 
            this.linkLabelChoiceFile.AutoSize = true;
            this.linkLabelChoiceFile.Location = new System.Drawing.Point(12, 10);
            this.linkLabelChoiceFile.Name = "linkLabelChoiceFile";
            this.linkLabelChoiceFile.Size = new System.Drawing.Size(107, 20);
            this.linkLabelChoiceFile.TabIndex = 2;
            this.linkLabelChoiceFile.TabStop = true;
            this.linkLabelChoiceFile.Text = "выбрать файл";
            this.linkLabelChoiceFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChoiceFile_LinkClicked);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(125, 6);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(94, 29);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panelOutputData
            // 
            this.panelOutputData.AutoScroll = true;
            this.panelOutputData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelOutputData.Controls.Add(this.labelOutputData);
            this.panelOutputData.Location = new System.Drawing.Point(12, 41);
            this.panelOutputData.Name = "panelOutputData";
            this.panelOutputData.Size = new System.Drawing.Size(520, 410);
            this.panelOutputData.TabIndex = 4;
            // 
            // labelOutputData
            // 
            this.labelOutputData.AutoSize = true;
            this.labelOutputData.Location = new System.Drawing.Point(13, 9);
            this.labelOutputData.Name = "labelOutputData";
            this.labelOutputData.Size = new System.Drawing.Size(303, 20);
            this.labelOutputData.TabIndex = 0;
            this.labelOutputData.Text = "выберите файл для работы со студентами";
            // 
            // buttonNewInNew
            // 
            this.buttonNewInNew.Location = new System.Drawing.Point(12, 457);
            this.buttonNewInNew.Name = "buttonNewInNew";
            this.buttonNewInNew.Size = new System.Drawing.Size(258, 29);
            this.buttonNewInNew.TabIndex = 5;
            this.buttonNewInNew.Text = "создать студента в новый файл";
            this.buttonNewInNew.UseVisualStyleBackColor = true;
            this.buttonNewInNew.Click += new System.EventHandler(this.buttonNewInNew_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(270, 457);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(262, 29);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "добавить студента в текущий файл";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(18, 509);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(223, 20);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "Работа со студентом по его ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(239, 506);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(31, 27);
            this.textBoxID.TabIndex = 8;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(114, 539);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(90, 29);
            this.buttonChange.TabIndex = 9;
            this.buttonChange.Text = "изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(18, 539);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 29);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDance
            // 
            this.buttonDance.Location = new System.Drawing.Point(210, 539);
            this.buttonDance.Name = "buttonDance";
            this.buttonDance.Size = new System.Drawing.Size(90, 29);
            this.buttonDance.TabIndex = 11;
            this.buttonDance.Text = "танцевать!";
            this.buttonDance.UseVisualStyleBackColor = true;
            this.buttonDance.Click += new System.EventHandler(this.buttonDance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(544, 581);
            this.Controls.Add(this.buttonDance);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonNewInNew);
            this.Controls.Add(this.panelOutputData);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.linkLabelChoiceFile);
            this.Controls.Add(this.linkLabelOpenTaxiDriver);
            this.Controls.Add(this.linkLabelOpenAcrobat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студенты";
            this.panelOutputData.ResumeLayout(false);
            this.panelOutputData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabelOpenAcrobat;
        private LinkLabel linkLabelOpenTaxiDriver;
        private LinkLabel linkLabelChoiceFile;
        private Button buttonUpdate;
        private Panel panelOutputData;
        private Label labelOutputData;
        private Button buttonNewInNew;
        private Button buttonNew;
        private Label labelID;
        private TextBox textBoxID;
        private Button buttonChange;
        private Button buttonDelete;
        private Button buttonDance;
    }
}