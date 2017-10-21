namespace AirMonit_Admin
{
    partial class Form1
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
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.lblCities = new System.Windows.Forms.Label();
            this.lstViewInfo = new System.Windows.Forms.ListView();
            this.groupBoxAlarms = new System.Windows.Forms.GroupBox();
            this.datePikerStart = new System.Windows.Forms.DateTimePicker();
            this.lblAlarmsBetween = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBoxUsers = new System.Windows.Forms.GroupBox();
            this.groupBoxGraphics = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAlarms.SuspendLayout();
            this.groupBoxUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(26, 62);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(265, 21);
            this.comboBoxCities.TabIndex = 0;
            // 
            // lblCities
            // 
            this.lblCities.AutoSize = true;
            this.lblCities.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCities.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCities.Location = new System.Drawing.Point(22, 28);
            this.lblCities.Name = "lblCities";
            this.lblCities.Size = new System.Drawing.Size(110, 22);
            this.lblCities.TabIndex = 1;
            this.lblCities.Text = "Choose city";
            // 
            // lstViewInfo
            // 
            this.lstViewInfo.Location = new System.Drawing.Point(6, 198);
            this.lstViewInfo.Name = "lstViewInfo";
            this.lstViewInfo.Size = new System.Drawing.Size(257, 197);
            this.lstViewInfo.TabIndex = 2;
            this.lstViewInfo.UseCompatibleStateImageBehavior = false;
            this.lstViewInfo.View = System.Windows.Forms.View.List;
            // 
            // groupBoxAlarms
            // 
            this.groupBoxAlarms.Controls.Add(this.datePickerEnd);
            this.groupBoxAlarms.Controls.Add(this.label1);
            this.groupBoxAlarms.Controls.Add(this.datePikerStart);
            this.groupBoxAlarms.Controls.Add(this.lblAlarmsBetween);
            this.groupBoxAlarms.Controls.Add(this.lstViewInfo);
            this.groupBoxAlarms.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAlarms.Location = new System.Drawing.Point(26, 103);
            this.groupBoxAlarms.Name = "groupBoxAlarms";
            this.groupBoxAlarms.Size = new System.Drawing.Size(274, 407);
            this.groupBoxAlarms.TabIndex = 5;
            this.groupBoxAlarms.TabStop = false;
            this.groupBoxAlarms.Text = "Alarms";
            // 
            // datePikerStart
            // 
            this.datePikerStart.CalendarFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePikerStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePikerStart.Location = new System.Drawing.Point(10, 59);
            this.datePikerStart.Name = "datePikerStart";
            this.datePikerStart.Size = new System.Drawing.Size(200, 22);
            this.datePikerStart.TabIndex = 6;
            // 
            // lblAlarmsBetween
            // 
            this.lblAlarmsBetween.AutoSize = true;
            this.lblAlarmsBetween.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmsBetween.Location = new System.Drawing.Point(7, 29);
            this.lblAlarmsBetween.Name = "lblAlarmsBetween";
            this.lblAlarmsBetween.Size = new System.Drawing.Size(142, 18);
            this.lblAlarmsBetween.TabIndex = 3;
            this.lblAlarmsBetween.Text = "Triggered between:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "and:";
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerEnd.Location = new System.Drawing.Point(10, 140);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(200, 22);
            this.datePickerEnd.TabIndex = 8;
            // 
            // groupBoxUsers
            // 
            this.groupBoxUsers.Controls.Add(this.label2);
            this.groupBoxUsers.Controls.Add(this.listView1);
            this.groupBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUsers.Location = new System.Drawing.Point(331, 28);
            this.groupBoxUsers.Name = "groupBoxUsers";
            this.groupBoxUsers.Size = new System.Drawing.Size(327, 482);
            this.groupBoxUsers.TabIndex = 6;
            this.groupBoxUsers.TabStop = false;
            this.groupBoxUsers.Text = "Users info";
            // 
            // groupBoxGraphics
            // 
            this.groupBoxGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGraphics.Location = new System.Drawing.Point(686, 28);
            this.groupBoxGraphics.Name = "groupBoxGraphics";
            this.groupBoxGraphics.Size = new System.Drawing.Size(473, 476);
            this.groupBoxGraphics.TabIndex = 7;
            this.groupBoxGraphics.TabStop = false;
            this.groupBoxGraphics.Text = "Graphics";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(315, 383);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uncommon events:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 542);
            this.Controls.Add(this.groupBoxGraphics);
            this.Controls.Add(this.groupBoxUsers);
            this.Controls.Add(this.groupBoxAlarms);
            this.Controls.Add(this.lblCities);
            this.Controls.Add(this.comboBoxCities);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAlarms.ResumeLayout(false);
            this.groupBoxAlarms.PerformLayout();
            this.groupBoxUsers.ResumeLayout(false);
            this.groupBoxUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Label lblCities;
        private System.Windows.Forms.ListView lstViewInfo;
        private System.Windows.Forms.GroupBox groupBoxAlarms;
        private System.Windows.Forms.Label lblAlarmsBetween;
        private System.Windows.Forms.DateTimePicker datePikerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerEnd;
        private System.Windows.Forms.GroupBox groupBoxUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBoxGraphics;
    }
}

