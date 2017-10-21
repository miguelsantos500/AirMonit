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
            // AirMonit_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAlarmState);
            this.Controls.Add(this.lblAlarms);
            this.Controls.Add(this.btnToggleAlarm);
            this.Name = "AirMonit_Alarm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToggleAlarm;
        private System.Windows.Forms.Label lblAlarms;
        private System.Windows.Forms.Label lblAlarmState;
    }
}

