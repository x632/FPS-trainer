namespace Måltavla
{
	partial class Startknapp
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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Lblrnd = new System.Windows.Forms.Label();
			this.LblY = new System.Windows.Forms.Label();
			this.btnRestart = new System.Windows.Forms.Button();
			this.UpDown = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.UpDownSpeed = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.UpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UpDownSpeed)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 55;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// Lblrnd
			// 
			this.Lblrnd.AutoSize = true;
			this.Lblrnd.Location = new System.Drawing.Point(805, 83);
			this.Lblrnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Lblrnd.Name = "Lblrnd";
			this.Lblrnd.Size = new System.Drawing.Size(20, 23);
			this.Lblrnd.TabIndex = 3;
			this.Lblrnd.Text = "X";
			// 
			// LblY
			// 
			this.LblY.AutoSize = true;
			this.LblY.Location = new System.Drawing.Point(787, 39);
			this.LblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LblY.Name = "LblY";
			this.LblY.Size = new System.Drawing.Size(53, 23);
			this.LblY.TabIndex = 4;
			this.LblY.Text = "Ammo";
			// 
			// btnRestart
			// 
			this.btnRestart.Location = new System.Drawing.Point(39, 39);
			this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnRestart.Name = "btnRestart";
			this.btnRestart.Size = new System.Drawing.Size(100, 41);
			this.btnRestart.TabIndex = 5;
			this.btnRestart.Text = "Restart";
			this.btnRestart.UseVisualStyleBackColor = true;
			this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
			// 
			// UpDown
			// 
			this.UpDown.Location = new System.Drawing.Point(26, 525);
			this.UpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.UpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.UpDown.Name = "UpDown";
			this.UpDown.Size = new System.Drawing.Size(52, 30);
			this.UpDown.TabIndex = 6;
			this.UpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.UpDown.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 484);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Size";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(833, 484);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Speed";
			// 
			// UpDownSpeed
			// 
			this.UpDownSpeed.Location = new System.Drawing.Point(837, 525);
			this.UpDownSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.UpDownSpeed.Name = "UpDownSpeed";
			this.UpDownSpeed.Size = new System.Drawing.Size(45, 30);
			this.UpDownSpeed.TabIndex = 10;
			this.UpDownSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.UpDownSpeed.ValueChanged += new System.EventHandler(this.UpDownSpeed_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(791, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "SCORE:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(805, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "0";
			// 
			// Startknapp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.BackgroundImage = global::Måltavla.Properties.Resources.Metallvägg;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(932, 576);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.UpDownSpeed);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UpDown);
			this.Controls.Add(this.btnRestart);
			this.Controls.Add(this.LblY);
			this.Controls.Add(this.Lblrnd);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Startknapp";
			this.Text = "Aiming Game";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.UpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UpDownSpeed)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label Lblrnd;
		private System.Windows.Forms.Label LblY;
		private System.Windows.Forms.Button btnRestart;
		private System.Windows.Forms.NumericUpDown UpDown;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown UpDownSpeed;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

