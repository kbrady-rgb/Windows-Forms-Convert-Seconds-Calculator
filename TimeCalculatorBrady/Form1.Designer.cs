namespace TimeCalculatorBrady
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
            this.lblSeconds = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.lblSecondsOutput = new System.Windows.Forms.Label();
            this.lblMinutesOutput = new System.Windows.Forms.Label();
            this.lblHoursOutput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSecs = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDaysOutput = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.gbResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(56, 31);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(105, 17);
            this.lblSeconds.TabIndex = 0;
            this.lblSeconds.Text = "Enter Seconds:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(47, 294);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(150, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(243, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.lblSecondsOutput);
            this.gbResults.Controls.Add(this.lblMinutesOutput);
            this.gbResults.Controls.Add(this.lblHoursOutput);
            this.gbResults.Controls.Add(this.label7);
            this.gbResults.Controls.Add(this.lblSecs);
            this.gbResults.Controls.Add(this.lblMinutes);
            this.gbResults.Controls.Add(this.lblHours);
            this.gbResults.Controls.Add(this.lblDaysOutput);
            this.gbResults.Controls.Add(this.lblDays);
            this.gbResults.Location = new System.Drawing.Point(54, 74);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(254, 195);
            this.gbResults.TabIndex = 13;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // lblSecondsOutput
            // 
            this.lblSecondsOutput.AutoSize = true;
            this.lblSecondsOutput.Location = new System.Drawing.Point(169, 153);
            this.lblSecondsOutput.Name = "lblSecondsOutput";
            this.lblSecondsOutput.Size = new System.Drawing.Size(16, 17);
            this.lblSecondsOutput.TabIndex = 16;
            this.lblSecondsOutput.Text = "0";
            // 
            // lblMinutesOutput
            // 
            this.lblMinutesOutput.AutoSize = true;
            this.lblMinutesOutput.Location = new System.Drawing.Point(169, 116);
            this.lblMinutesOutput.Name = "lblMinutesOutput";
            this.lblMinutesOutput.Size = new System.Drawing.Size(16, 17);
            this.lblMinutesOutput.TabIndex = 15;
            this.lblMinutesOutput.Text = "0";
            // 
            // lblHoursOutput
            // 
            this.lblHoursOutput.AutoSize = true;
            this.lblHoursOutput.Location = new System.Drawing.Point(169, 76);
            this.lblHoursOutput.Name = "lblHoursOutput";
            this.lblHoursOutput.Size = new System.Drawing.Size(16, 17);
            this.lblHoursOutput.TabIndex = 14;
            this.lblHoursOutput.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, -19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // lblSecs
            // 
            this.lblSecs.AutoSize = true;
            this.lblSecs.Location = new System.Drawing.Point(34, 153);
            this.lblSecs.Name = "lblSecs";
            this.lblSecs.Size = new System.Drawing.Size(67, 17);
            this.lblSecs.TabIndex = 12;
            this.lblSecs.Text = "Seconds:";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(34, 116);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(61, 17);
            this.lblMinutes.TabIndex = 11;
            this.lblMinutes.Text = "Minutes:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(34, 76);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(50, 17);
            this.lblHours.TabIndex = 10;
            this.lblHours.Text = "Hours:";
            // 
            // lblDaysOutput
            // 
            this.lblDaysOutput.AutoSize = true;
            this.lblDaysOutput.Location = new System.Drawing.Point(169, 37);
            this.lblDaysOutput.Name = "lblDaysOutput";
            this.lblDaysOutput.Size = new System.Drawing.Size(16, 17);
            this.lblDaysOutput.TabIndex = 3;
            this.lblDaysOutput.Text = "0";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(34, 37);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(44, 17);
            this.lblDays.TabIndex = 2;
            this.lblDays.Text = "Days:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(199, 26);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(394, 370);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSeconds);
            this.Name = "Form1";
            this.Text = "Time Calculator";
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.Label lblSecondsOutput;
        private System.Windows.Forms.Label lblMinutesOutput;
        private System.Windows.Forms.Label lblHoursOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSecs;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDaysOutput;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtInput;
    }
}

