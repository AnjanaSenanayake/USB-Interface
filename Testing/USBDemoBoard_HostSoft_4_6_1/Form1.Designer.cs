namespace USBDemoBoard
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
            this.components = new System.ComponentModel.Container();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblSwitchStates = new System.Windows.Forms.Label();
            this.lblSwitch1 = new System.Windows.Forms.Label();
            this.lblSwitch2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoLED1Off = new System.Windows.Forms.RadioButton();
            this.rdoLED1On = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoLED2Off = new System.Windows.Forms.RadioButton();
            this.rdoLED2On = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoLED3Off = new System.Windows.Forms.RadioButton();
            this.rdoLED3On = new System.Windows.Forms.RadioButton();
            this.tmrUSB = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoLED4Off = new System.Windows.Forms.RadioButton();
            this.rdoLED4On = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoLED5Off = new System.Windows.Forms.RadioButton();
            this.rdoLED5On = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdoLED0Off = new System.Windows.Forms.RadioButton();
            this.rdoLED0On = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 3);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(321, 23);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // lblSwitchStates
            // 
            this.lblSwitchStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitchStates.Location = new System.Drawing.Point(56, 39);
            this.lblSwitchStates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSwitchStates.Name = "lblSwitchStates";
            this.lblSwitchStates.Size = new System.Drawing.Size(99, 23);
            this.lblSwitchStates.TabIndex = 1;
            this.lblSwitchStates.Text = "switch states:";
            // 
            // lblSwitch1
            // 
            this.lblSwitch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSwitch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitch1.Location = new System.Drawing.Point(57, 62);
            this.lblSwitch1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSwitch1.Name = "lblSwitch1";
            this.lblSwitch1.Size = new System.Drawing.Size(160, 23);
            this.lblSwitch1.TabIndex = 2;
            this.lblSwitch1.Text = "switch 1 is not pressed";
            // 
            // lblSwitch2
            // 
            this.lblSwitch2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSwitch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitch2.Location = new System.Drawing.Point(57, 91);
            this.lblSwitch2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSwitch2.Name = "lblSwitch2";
            this.lblSwitch2.Size = new System.Drawing.Size(160, 23);
            this.lblSwitch2.TabIndex = 3;
            this.lblSwitch2.Text = "switch 2 is not pressed";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoLED1Off);
            this.groupBox1.Controls.Add(this.rdoLED1On);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(81, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(66, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED 1:";
            // 
            // rdoLED1Off
            // 
            this.rdoLED1Off.AutoSize = true;
            this.rdoLED1Off.Checked = true;
            this.rdoLED1Off.Location = new System.Drawing.Point(12, 55);
            this.rdoLED1Off.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLED1Off.Name = "rdoLED1Off";
            this.rdoLED1Off.Size = new System.Drawing.Size(40, 20);
            this.rdoLED1Off.TabIndex = 1;
            this.rdoLED1Off.TabStop = true;
            this.rdoLED1Off.Text = "off";
            this.rdoLED1Off.UseVisualStyleBackColor = true;
            // 
            // rdoLED1On
            // 
            this.rdoLED1On.AutoSize = true;
            this.rdoLED1On.Location = new System.Drawing.Point(12, 26);
            this.rdoLED1On.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLED1On.Name = "rdoLED1On";
            this.rdoLED1On.Size = new System.Drawing.Size(41, 20);
            this.rdoLED1On.TabIndex = 0;
            this.rdoLED1On.Text = "on";
            this.rdoLED1On.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoLED2Off);
            this.groupBox2.Controls.Add(this.rdoLED2On);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(161, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(66, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED 2:";
            // 
            // rdoLED2Off
            // 
            this.rdoLED2Off.AutoSize = true;
            this.rdoLED2Off.Checked = true;
            this.rdoLED2Off.Location = new System.Drawing.Point(12, 55);
            this.rdoLED2Off.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLED2Off.Name = "rdoLED2Off";
            this.rdoLED2Off.Size = new System.Drawing.Size(40, 20);
            this.rdoLED2Off.TabIndex = 1;
            this.rdoLED2Off.TabStop = true;
            this.rdoLED2Off.Text = "off";
            this.rdoLED2Off.UseVisualStyleBackColor = true;
            // 
            // rdoLED2On
            // 
            this.rdoLED2On.AutoSize = true;
            this.rdoLED2On.Location = new System.Drawing.Point(12, 26);
            this.rdoLED2On.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLED2On.Name = "rdoLED2On";
            this.rdoLED2On.Size = new System.Drawing.Size(41, 20);
            this.rdoLED2On.TabIndex = 0;
            this.rdoLED2On.Text = "on";
            this.rdoLED2On.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoLED3Off);
            this.groupBox3.Controls.Add(this.rdoLED3On);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(280, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(66, 88);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LED 3:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rdoLED3Off
            // 
            this.rdoLED3Off.AutoSize = true;
            this.rdoLED3Off.Checked = true;
            this.rdoLED3Off.Location = new System.Drawing.Point(12, 55);
            this.rdoLED3Off.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLED3Off.Name = "rdoLED3Off";
            this.rdoLED3Off.Size = new System.Drawing.Size(40, 20);
            this.rdoLED3Off.TabIndex = 1;
            this.rdoLED3Off.TabStop = true;
            this.rdoLED3Off.Text = "off";
            this.rdoLED3Off.UseVisualStyleBackColor = true;
            // 
            // rdoLED3On
            // 
            this.rdoLED3On.AutoSize = true;
            this.rdoLED3On.Location = new System.Drawing.Point(12, 26);
            this.rdoLED3On.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLED3On.Name = "rdoLED3On";
            this.rdoLED3On.Size = new System.Drawing.Size(41, 20);
            this.rdoLED3On.TabIndex = 0;
            this.rdoLED3On.Text = "on";
            this.rdoLED3On.UseVisualStyleBackColor = true;
            // 
            // tmrUSB
            // 
            this.tmrUSB.Interval = 50;
            this.tmrUSB.Tick += new System.EventHandler(this.tmrUSB_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoLED4Off);
            this.groupBox4.Controls.Add(this.rdoLED4On);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(350, 124);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(66, 88);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LED 4:";
            // 
            // rdoLED4Off
            // 
            this.rdoLED4Off.AutoSize = true;
            this.rdoLED4Off.Checked = true;
            this.rdoLED4Off.Location = new System.Drawing.Point(12, 55);
            this.rdoLED4Off.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLED4Off.Name = "rdoLED4Off";
            this.rdoLED4Off.Size = new System.Drawing.Size(40, 20);
            this.rdoLED4Off.TabIndex = 1;
            this.rdoLED4Off.TabStop = true;
            this.rdoLED4Off.Text = "off";
            this.rdoLED4Off.UseVisualStyleBackColor = true;
            // 
            // rdoLED4On
            // 
            this.rdoLED4On.AutoSize = true;
            this.rdoLED4On.Location = new System.Drawing.Point(12, 26);
            this.rdoLED4On.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLED4On.Name = "rdoLED4On";
            this.rdoLED4On.Size = new System.Drawing.Size(41, 20);
            this.rdoLED4On.TabIndex = 0;
            this.rdoLED4On.Text = "on";
            this.rdoLED4On.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoLED5Off);
            this.groupBox5.Controls.Add(this.rdoLED5On);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(420, 124);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(66, 88);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "LED 5";
            // 
            // rdoLED5Off
            // 
            this.rdoLED5Off.AutoSize = true;
            this.rdoLED5Off.Checked = true;
            this.rdoLED5Off.Location = new System.Drawing.Point(12, 55);
            this.rdoLED5Off.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLED5Off.Name = "rdoLED5Off";
            this.rdoLED5Off.Size = new System.Drawing.Size(40, 20);
            this.rdoLED5Off.TabIndex = 1;
            this.rdoLED5Off.TabStop = true;
            this.rdoLED5Off.Text = "off";
            this.rdoLED5Off.UseVisualStyleBackColor = true;
            // 
            // rdoLED5On
            // 
            this.rdoLED5On.AutoSize = true;
            this.rdoLED5On.Location = new System.Drawing.Point(12, 26);
            this.rdoLED5On.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLED5On.Name = "rdoLED5On";
            this.rdoLED5On.Size = new System.Drawing.Size(41, 20);
            this.rdoLED5On.TabIndex = 0;
            this.rdoLED5On.Text = "on";
            this.rdoLED5On.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdoLED0Off);
            this.groupBox6.Controls.Add(this.rdoLED0On);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(11, 124);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(66, 88);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "LED 0";
            // 
            // rdoLED0Off
            // 
            this.rdoLED0Off.AutoSize = true;
            this.rdoLED0Off.Checked = true;
            this.rdoLED0Off.Location = new System.Drawing.Point(12, 55);
            this.rdoLED0Off.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLED0Off.Name = "rdoLED0Off";
            this.rdoLED0Off.Size = new System.Drawing.Size(40, 20);
            this.rdoLED0Off.TabIndex = 1;
            this.rdoLED0Off.TabStop = true;
            this.rdoLED0Off.Text = "off";
            this.rdoLED0Off.UseVisualStyleBackColor = true;
            // 
            // rdoLED0On
            // 
            this.rdoLED0On.AutoSize = true;
            this.rdoLED0On.Location = new System.Drawing.Point(12, 26);
            this.rdoLED0On.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLED0On.Name = "rdoLED0On";
            this.rdoLED0On.Size = new System.Drawing.Size(41, 20);
            this.rdoLED0On.TabIndex = 0;
            this.rdoLED0On.Text = "on";
            this.rdoLED0On.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 303);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSwitch2);
            this.Controls.Add(this.lblSwitch1);
            this.Controls.Add(this.lblSwitchStates);
            this.Controls.Add(this.lblInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Label lblSwitchStates;
		private System.Windows.Forms.Label lblSwitch1;
		private System.Windows.Forms.Label lblSwitch2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdoLED1Off;
		private System.Windows.Forms.RadioButton rdoLED1On;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rdoLED2Off;
		private System.Windows.Forms.RadioButton rdoLED2On;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rdoLED3Off;
		private System.Windows.Forms.RadioButton rdoLED3On;
		private System.Windows.Forms.Timer tmrUSB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoLED4Off;
        private System.Windows.Forms.RadioButton rdoLED4On;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoLED5Off;
        private System.Windows.Forms.RadioButton rdoLED5On;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rdoLED0Off;
        private System.Windows.Forms.RadioButton rdoLED0On;
	}
}

