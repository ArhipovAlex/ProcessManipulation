namespace ProcessManipulation
{
	partial class MainForm
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
			this.listBoxAvalibleAssembles = new System.Windows.Forms.ListBox();
			this.listBoxStartedAssembles = new System.Windows.Forms.ListBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.labelAvalibleAssembles = new System.Windows.Forms.Label();
			this.labelStartedAssembles = new System.Windows.Forms.Label();
			this.buttonStop = new System.Windows.Forms.Button();
			this.buttonCloseWindow = new System.Windows.Forms.Button();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxAvalibleAssembles
			// 
			this.listBoxAvalibleAssembles.FormattingEnabled = true;
			this.listBoxAvalibleAssembles.ItemHeight = 16;
			this.listBoxAvalibleAssembles.Location = new System.Drawing.Point(12, 43);
			this.listBoxAvalibleAssembles.Name = "listBoxAvalibleAssembles";
			this.listBoxAvalibleAssembles.Size = new System.Drawing.Size(312, 308);
			this.listBoxAvalibleAssembles.TabIndex = 0;
			// 
			// listBoxStartedAssembles
			// 
			this.listBoxStartedAssembles.FormattingEnabled = true;
			this.listBoxStartedAssembles.ItemHeight = 16;
			this.listBoxStartedAssembles.Location = new System.Drawing.Point(476, 43);
			this.listBoxStartedAssembles.Name = "listBoxStartedAssembles";
			this.listBoxStartedAssembles.Size = new System.Drawing.Size(312, 308);
			this.listBoxStartedAssembles.TabIndex = 1;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(330, 43);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(140, 29);
			this.buttonStart.TabIndex = 2;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// labelAvalibleAssembles
			// 
			this.labelAvalibleAssembles.AutoSize = true;
			this.labelAvalibleAssembles.Location = new System.Drawing.Point(12, 9);
			this.labelAvalibleAssembles.Name = "labelAvalibleAssembles";
			this.labelAvalibleAssembles.Size = new System.Drawing.Size(128, 16);
			this.labelAvalibleAssembles.TabIndex = 3;
			this.labelAvalibleAssembles.Text = "Доступные сборки";
			// 
			// labelStartedAssembles
			// 
			this.labelStartedAssembles.AutoSize = true;
			this.labelStartedAssembles.Location = new System.Drawing.Point(473, 9);
			this.labelStartedAssembles.Name = "labelStartedAssembles";
			this.labelStartedAssembles.Size = new System.Drawing.Size(139, 16);
			this.labelStartedAssembles.TabIndex = 4;
			this.labelStartedAssembles.Text = "Запущенные сборки";
			// 
			// buttonStop
			// 
			this.buttonStop.Location = new System.Drawing.Point(330, 78);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(140, 29);
			this.buttonStop.TabIndex = 5;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// buttonCloseWindow
			// 
			this.buttonCloseWindow.Location = new System.Drawing.Point(330, 113);
			this.buttonCloseWindow.Name = "buttonCloseWindow";
			this.buttonCloseWindow.Size = new System.Drawing.Size(140, 29);
			this.buttonCloseWindow.TabIndex = 6;
			this.buttonCloseWindow.Text = "Close Window";
			this.buttonCloseWindow.UseVisualStyleBackColor = true;
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(330, 148);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(140, 29);
			this.buttonRefresh.TabIndex = 7;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.buttonCloseWindow);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.labelStartedAssembles);
			this.Controls.Add(this.labelAvalibleAssembles);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.listBoxStartedAssembles);
			this.Controls.Add(this.listBoxAvalibleAssembles);
			this.Name = "MainForm";
			this.Text = "Manipulator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxAvalibleAssembles;
		private System.Windows.Forms.ListBox listBoxStartedAssembles;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label labelAvalibleAssembles;
		private System.Windows.Forms.Label labelStartedAssembles;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Button buttonCloseWindow;
		private System.Windows.Forms.Button buttonRefresh;
	}
}

