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
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.datePikerStart = new System.Windows.Forms.DateTimePicker();
            this.lblAlarmsBetween = new System.Windows.Forms.Label();
            this.groupBoxUsers = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.btnCO = new System.Windows.Forms.Button();
            this.btnO3 = new System.Windows.Forms.Button();
            this.btnNO2 = new System.Windows.Forms.Button();
            this.lblDayStatistics = new System.Windows.Forms.Label();
            this.datePickerStatistics = new System.Windows.Forms.DateTimePicker();
            this.groupBoxAlarms.SuspendLayout();
            this.groupBoxUsers.SuspendLayout();
            this.groupBoxStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(35, 76);
            this.comboBoxCities.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(352, 24);
            this.comboBoxCities.TabIndex = 0;
            // 
            // lblCities
            // 
            this.lblCities.AutoSize = true;
            this.lblCities.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCities.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCities.Location = new System.Drawing.Point(29, 34);
            this.lblCities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCities.Name = "lblCities";
            this.lblCities.Size = new System.Drawing.Size(137, 27);
            this.lblCities.TabIndex = 1;
            this.lblCities.Text = "Choose city";
            // 
            // lstViewInfo
            // 
            this.lstViewInfo.Location = new System.Drawing.Point(8, 244);
            this.lstViewInfo.Margin = new System.Windows.Forms.Padding(4);
            this.lstViewInfo.Name = "lstViewInfo";
            this.lstViewInfo.Size = new System.Drawing.Size(341, 242);
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
            this.groupBoxAlarms.Location = new System.Drawing.Point(35, 127);
            this.groupBoxAlarms.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAlarms.Name = "groupBoxAlarms";
            this.groupBoxAlarms.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAlarms.Size = new System.Drawing.Size(365, 501);
            this.groupBoxAlarms.TabIndex = 5;
            this.groupBoxAlarms.TabStop = false;
            this.groupBoxAlarms.Text = "Alarms";
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerEnd.Location = new System.Drawing.Point(165, 180);
            this.datePickerEnd.Margin = new System.Windows.Forms.Padding(4);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(184, 26);
            this.datePickerEnd.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "and:";
            // 
            // datePikerStart
            // 
            this.datePikerStart.CalendarFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePikerStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePikerStart.Location = new System.Drawing.Point(165, 76);
            this.datePikerStart.Margin = new System.Windows.Forms.Padding(4);
            this.datePikerStart.Name = "datePikerStart";
            this.datePikerStart.Size = new System.Drawing.Size(184, 26);
            this.datePikerStart.TabIndex = 6;
            // 
            // lblAlarmsBetween
            // 
            this.lblAlarmsBetween.AutoSize = true;
            this.lblAlarmsBetween.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmsBetween.Location = new System.Drawing.Point(9, 36);
            this.lblAlarmsBetween.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlarmsBetween.Name = "lblAlarmsBetween";
            this.lblAlarmsBetween.Size = new System.Drawing.Size(181, 23);
            this.lblAlarmsBetween.TabIndex = 3;
            this.lblAlarmsBetween.Text = "Triggered between:";
            // 
            // groupBoxUsers
            // 
            this.groupBoxUsers.Controls.Add(this.label2);
            this.groupBoxUsers.Controls.Add(this.listView1);
            this.groupBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUsers.Location = new System.Drawing.Point(441, 34);
            this.groupBoxUsers.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUsers.Name = "groupBoxUsers";
            this.groupBoxUsers.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUsers.Size = new System.Drawing.Size(436, 593);
            this.groupBoxUsers.TabIndex = 6;
            this.groupBoxUsers.TabStop = false;
            this.groupBoxUsers.Text = "Users info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uncommon events:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(8, 107);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(419, 470);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Controls.Add(this.btnCO);
            this.groupBoxStatistics.Controls.Add(this.btnO3);
            this.groupBoxStatistics.Controls.Add(this.btnNO2);
            this.groupBoxStatistics.Controls.Add(this.lblDayStatistics);
            this.groupBoxStatistics.Controls.Add(this.datePickerStatistics);
            this.groupBoxStatistics.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStatistics.Location = new System.Drawing.Point(915, 34);
            this.groupBoxStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStatistics.Size = new System.Drawing.Size(631, 586);
            this.groupBoxStatistics.TabIndex = 7;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistics";
            // 
            // btnCO
            // 
            this.btnCO.BackColor = System.Drawing.Color.Aqua;
            this.btnCO.FlatAppearance.BorderSize = 0;
            this.btnCO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCO.Location = new System.Drawing.Point(539, 306);
            this.btnCO.Name = "btnCO";
            this.btnCO.Size = new System.Drawing.Size(75, 68);
            this.btnCO.TabIndex = 4;
            this.btnCO.Text = "CO";
            this.btnCO.UseVisualStyleBackColor = false;
            // 
            // btnO3
            // 
            this.btnO3.BackColor = System.Drawing.Color.Lime;
            this.btnO3.FlatAppearance.BorderSize = 0;
            this.btnO3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnO3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO3.Location = new System.Drawing.Point(539, 210);
            this.btnO3.Name = "btnO3";
            this.btnO3.Size = new System.Drawing.Size(75, 68);
            this.btnO3.TabIndex = 3;
            this.btnO3.Text = "O3";
            this.btnO3.UseVisualStyleBackColor = false;
            // 
            // btnNO2
            // 
            this.btnNO2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNO2.FlatAppearance.BorderSize = 0;
            this.btnNO2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNO2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNO2.Location = new System.Drawing.Point(539, 107);
            this.btnNO2.Name = "btnNO2";
            this.btnNO2.Size = new System.Drawing.Size(75, 68);
            this.btnNO2.TabIndex = 2;
            this.btnNO2.Text = "NO2";
            this.btnNO2.UseVisualStyleBackColor = false;
            // 
            // lblDayStatistics
            // 
            this.lblDayStatistics.AutoSize = true;
            this.lblDayStatistics.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDayStatistics.Location = new System.Drawing.Point(409, 18);
            this.lblDayStatistics.Name = "lblDayStatistics";
            this.lblDayStatistics.Size = new System.Drawing.Size(115, 23);
            this.lblDayStatistics.TabIndex = 1;
            this.lblDayStatistics.Text = "Choose day";
            // 
            // datePickerStatistics
            // 
            this.datePickerStatistics.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerStatistics.Location = new System.Drawing.Point(413, 50);
            this.datePickerStatistics.Name = "datePickerStatistics";
            this.datePickerStatistics.Size = new System.Drawing.Size(201, 28);
            this.datePickerStatistics.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 667);
            this.Controls.Add(this.groupBoxStatistics);
            this.Controls.Add(this.groupBoxUsers);
            this.Controls.Add(this.groupBoxAlarms);
            this.Controls.Add(this.lblCities);
            this.Controls.Add(this.comboBoxCities);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "AirMonit Admin";
            this.groupBoxAlarms.ResumeLayout(false);
            this.groupBoxAlarms.PerformLayout();
            this.groupBoxUsers.ResumeLayout(false);
            this.groupBoxUsers.PerformLayout();
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.Button btnCO;
        private System.Windows.Forms.Button btnO3;
        private System.Windows.Forms.Button btnNO2;
        private System.Windows.Forms.Label lblDayStatistics;
        private System.Windows.Forms.DateTimePicker datePickerStatistics;
    }
}

