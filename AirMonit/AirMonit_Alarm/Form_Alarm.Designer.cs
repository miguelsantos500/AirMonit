namespace AirMonit_Alarm
{
    partial class AirMonit_Alarm
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
            this.btnToggleAlarm = new System.Windows.Forms.Button();
            this.lblAlarms = new System.Windows.Forms.Label();
            this.lblAlarmState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxLocalization = new System.Windows.Forms.TextBox();
            this.txtBoxValue = new System.Windows.Forms.TextBox();
            this.txtBoxElement = new System.Windows.Forms.TextBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBoxAlarmXML = new System.Windows.Forms.TextBox();
            this.numUpDownCityElement = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCityElement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToggleAlarm
            // 
            this.btnToggleAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleAlarm.Location = new System.Drawing.Point(82, 128);
            this.btnToggleAlarm.Name = "btnToggleAlarm";
            this.btnToggleAlarm.Size = new System.Drawing.Size(111, 58);
            this.btnToggleAlarm.TabIndex = 0;
            this.btnToggleAlarm.Text = "Toggle Alarms";
            this.btnToggleAlarm.UseVisualStyleBackColor = true;
            this.btnToggleAlarm.Click += new System.EventHandler(this.btnToggleAlarm_Click);
            // 
            // lblAlarms
            // 
            this.lblAlarms.AutoSize = true;
            this.lblAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarms.Location = new System.Drawing.Point(62, 61);
            this.lblAlarms.Name = "lblAlarms";
            this.lblAlarms.Size = new System.Drawing.Size(62, 20);
            this.lblAlarms.TabIndex = 1;
            this.lblAlarms.Text = "Alarms:";
            // 
            // lblAlarmState
            // 
            this.lblAlarmState.AutoSize = true;
            this.lblAlarmState.BackColor = System.Drawing.Color.Lime;
            this.lblAlarmState.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmState.Location = new System.Drawing.Point(145, 54);
            this.lblAlarmState.Name = "lblAlarmState";
            this.lblAlarmState.Size = new System.Drawing.Size(66, 37);
            this.lblAlarmState.TabIndex = 2;
            this.lblAlarmState.Text = "ON";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUpDownCityElement);
            this.groupBox1.Controls.Add(this.txtBoxAlarmXML);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txtBoxDate);
            this.groupBox1.Controls.Add(this.txtBoxElement);
            this.groupBox1.Controls.Add(this.txtBoxValue);
            this.groupBox1.Controls.Add(this.txtBoxLocalization);
            this.groupBox1.Location = new System.Drawing.Point(268, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auxilliary Information";
            // 
            // txtBoxLocalization
            // 
            this.txtBoxLocalization.Location = new System.Drawing.Point(28, 19);
            this.txtBoxLocalization.Name = "txtBoxLocalization";
            this.txtBoxLocalization.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLocalization.TabIndex = 0;
            this.txtBoxLocalization.Text = "Leiria";
            // 
            // txtBoxValue
            // 
            this.txtBoxValue.Location = new System.Drawing.Point(28, 59);
            this.txtBoxValue.Name = "txtBoxValue";
            this.txtBoxValue.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValue.TabIndex = 1;
            this.txtBoxValue.Text = "1001";
            // 
            // txtBoxElement
            // 
            this.txtBoxElement.Location = new System.Drawing.Point(175, 19);
            this.txtBoxElement.Name = "txtBoxElement";
            this.txtBoxElement.Size = new System.Drawing.Size(100, 20);
            this.txtBoxElement.TabIndex = 2;
            this.txtBoxElement.Text = "NO2";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(175, 59);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDate.TabIndex = 3;
            this.txtBoxDate.Text = "28/10/2017 17:41:26";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(118, 95);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBoxAlarmXML
            // 
            this.txtBoxAlarmXML.Enabled = false;
            this.txtBoxAlarmXML.Location = new System.Drawing.Point(6, 137);
            this.txtBoxAlarmXML.Multiline = true;
            this.txtBoxAlarmXML.Name = "txtBoxAlarmXML";
            this.txtBoxAlarmXML.Size = new System.Drawing.Size(302, 134);
            this.txtBoxAlarmXML.TabIndex = 5;
            // 
            // numUpDownCityElement
            // 
            this.numUpDownCityElement.Location = new System.Drawing.Point(28, 95);
            this.numUpDownCityElement.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUpDownCityElement.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownCityElement.Name = "numUpDownCityElement";
            this.numUpDownCityElement.Size = new System.Drawing.Size(36, 20);
            this.numUpDownCityElement.TabIndex = 6;
            this.numUpDownCityElement.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AirMonit_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAlarmState);
            this.Controls.Add(this.lblAlarms);
            this.Controls.Add(this.btnToggleAlarm);
            this.Name = "AirMonit_Alarm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCityElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToggleAlarm;
        private System.Windows.Forms.Label lblAlarms;
        private System.Windows.Forms.Label lblAlarmState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxAlarmXML;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.TextBox txtBoxElement;
        private System.Windows.Forms.TextBox txtBoxValue;
        private System.Windows.Forms.TextBox txtBoxLocalization;
        private System.Windows.Forms.NumericUpDown numUpDownCityElement;
    }
}

