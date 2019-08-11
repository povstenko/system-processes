namespace SPHW1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.lsbx = new System.Windows.Forms.ListBox();
			this.lbl = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.prb = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(560, 400);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Refresh";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lsbx
			// 
			this.lsbx.BackColor = System.Drawing.SystemColors.Info;
			this.lsbx.FormattingEnabled = true;
			this.lsbx.HorizontalScrollbar = true;
			this.lsbx.Location = new System.Drawing.Point(4, 0);
			this.lsbx.Name = "lsbx";
			this.lsbx.ScrollAlwaysVisible = true;
			this.lsbx.Size = new System.Drawing.Size(631, 394);
			this.lsbx.TabIndex = 1;
			// 
			// lbl
			// 
			this.lbl.AutoSize = true;
			this.lbl.Location = new System.Drawing.Point(1, 405);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(248, 13);
			this.lbl.TabIndex = 2;
			this.lbl.Text = "Processes worked now: 0, Last update at 00:00:00";
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// prb
			// 
			this.prb.Location = new System.Drawing.Point(280, 400);
			this.prb.Name = "prb";
			this.prb.Size = new System.Drawing.Size(274, 23);
			this.prb.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(638, 429);
			this.Controls.Add(this.prb);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.lsbx);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Processes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox lsbx;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.ProgressBar prb;
	}
}

