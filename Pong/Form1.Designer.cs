namespace Pong
{
	partial class PongGame
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PongGame));
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.Ball1 = new System.Windows.Forms.PictureBox();
			this.Paddel1 = new System.Windows.Forms.PictureBox();
			this.Paddel2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Game = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.Startscreen = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Ball1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paddel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Paddel2)).BeginInit();
			this.Game.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// Ball1
			// 
			this.Ball1.BackColor = System.Drawing.Color.Transparent;
			this.Ball1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ball1.BackgroundImage")));
			this.Ball1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Ball1.Location = new System.Drawing.Point(521, 233);
			this.Ball1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Ball1.Name = "Ball1";
			this.Ball1.Size = new System.Drawing.Size(25, 25);
			this.Ball1.TabIndex = 2;
			this.Ball1.TabStop = false;
			// 
			// Paddel1
			// 
			this.Paddel1.BackColor = System.Drawing.Color.Transparent;
			this.Paddel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Paddel1.BackgroundImage")));
			this.Paddel1.Location = new System.Drawing.Point(3, 181);
			this.Paddel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Paddel1.Name = "Paddel1";
			this.Paddel1.Size = new System.Drawing.Size(21, 145);
			this.Paddel1.TabIndex = 0;
			this.Paddel1.TabStop = false;
			// 
			// Paddel2
			// 
			this.Paddel2.BackColor = System.Drawing.Color.Transparent;
			this.Paddel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Paddel2.BackgroundImage")));
			this.Paddel2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Paddel2.ErrorImage")));
			this.Paddel2.InitialImage = ((System.Drawing.Image)(resources.GetObject("Paddel2.InitialImage")));
			this.Paddel2.Location = new System.Drawing.Point(1064, 191);
			this.Paddel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Paddel2.Name = "Paddel2";
			this.Paddel2.Size = new System.Drawing.Size(21, 145);
			this.Paddel2.TabIndex = 1;
			this.Paddel2.TabStop = false;
			this.Paddel2.Click += new System.EventHandler(this.timer_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(459, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 41);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(599, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 41);
			this.label2.TabIndex = 5;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Black;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(490, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 45);
			this.label3.TabIndex = 6;
			this.label3.Text = "label3";
			// 
			// Game
			// 
			this.Game.BackColor = System.Drawing.Color.Transparent;
			this.Game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Game.Controls.Add(this.label4);
			this.Game.Controls.Add(this.Startscreen);
			this.Game.Controls.Add(this.label3);
			this.Game.Controls.Add(this.label2);
			this.Game.Controls.Add(this.label1);
			this.Game.Controls.Add(this.Paddel2);
			this.Game.Controls.Add(this.Paddel1);
			this.Game.Controls.Add(this.Ball1);
			this.Game.Location = new System.Drawing.Point(0, 0);
			this.Game.Name = "Game";
			this.Game.Size = new System.Drawing.Size(1085, 545);
			this.Game.TabIndex = 3;
			this.Game.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Window;
			this.label4.Location = new System.Drawing.Point(249, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(564, 206);
			this.label4.TabIndex = 8;
			this.label4.Text = "Pong Game\r\nClick to start\r\n";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// Startscreen
			// 
			this.Startscreen.Location = new System.Drawing.Point(0, 0);
			this.Startscreen.Name = "Startscreen";
			this.Startscreen.Size = new System.Drawing.Size(1095, 545);
			this.Startscreen.TabIndex = 7;
			this.Startscreen.Text = "label4";
			// 
			// PongGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1088, 548);
			this.Controls.Add(this.Game);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "PongGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pong Game";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PongGame_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PongGame_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.Ball1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paddel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Paddel2)).EndInit();
			this.Game.ResumeLayout(false);
			this.Game.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.PictureBox Ball1;
		private System.Windows.Forms.PictureBox Paddel1;
		private System.Windows.Forms.PictureBox Paddel2;
		protected System.Windows.Forms.Label label1;
		protected System.Windows.Forms.Label label2;
		protected System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel Game;
		private System.Windows.Forms.Label Startscreen;
		private System.Windows.Forms.Label label4;
	}
}

