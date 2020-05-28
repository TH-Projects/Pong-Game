using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong
{
	public partial class PongGame : Form
	{
		const int movementSpeed1 = 7;
		const int movementSpeed2 = 7;
		int movementspeedBall = 4; //y-Richtung
		int movementspeedBall2 = 6; //x-Richtung
		bool upPressed, downPressed;
		bool upPressedP2, downPressedP2;
		int Score1 = 0;
		int Score = 0;

		public PongGame()
		{
			InitializeComponent();
			timer.Stop();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			label1.Text = Score.ToString();
			label2.Text = Score1.ToString();
			label3.Text = "Score";
			Cursor.Hide();
			Ball1.Location = new Point(Ball1.Location.X + movementspeedBall2, Ball1.Location.Y + movementspeedBall);
			//Ball movement

			if (upPressed)
			{
				if (Paddel1.Location.Y - movementSpeed1 > 0)
					Paddel1.Location = new Point(Paddel1.Location.X, Paddel1.Location.Y - movementSpeed1);
			}
			else if (downPressed)
			{
				if (Paddel1.Location.Y + Paddel1.Height + movementSpeed1 < Game.Height)
					Paddel1.Location = new Point(Paddel1.Location.X, Paddel1.Location.Y + movementSpeed1);
			}
			//Bewegung paddel1

			if (upPressedP2)
			{
				if (Paddel2.Location.Y - movementSpeed2 > 0)
					Paddel2.Location = new Point(Paddel2.Location.X, Paddel2.Location.Y - movementSpeed2);
			}
			else if (downPressedP2)
			{
				if (Paddel2.Location.Y + Paddel2.Height + movementSpeed2 < Game.Height)
					Paddel2.Location = new Point(Paddel2.Location.X, Paddel2.Location.Y + movementSpeed2);
			}
			//Bewegung paddel2

			if (Ball1.Location.Y + movementspeedBall < 0)
			{
				movementspeedBall = movementspeedBall *- 1 ;
			}
			//Decke
			 
			if(Ball1.Location.Y + Ball1.Height + movementspeedBall > Game.Height) 
			{
				movementspeedBall = movementspeedBall * -1;
			}
			//Boden

			if (Ball1.Location.X + Ball1.Width + movementspeedBall2 > Paddel2.Bounds.X && Ball1.Location.Y < Paddel2.Bounds.Y + Paddel2.Height && Ball1.Location.Y > Paddel2.Bounds.Y)
			{
				if (movementspeedBall2 > 0)
					movementspeedBall2 = (movementspeedBall2 + 1) * -1;
				else
					movementspeedBall2 = (movementspeedBall2 - 1) * -1;
			}
			//invertierung Paddel2
			if (Ball1.Location.X + movementspeedBall2 < Paddel1.Bounds.X + Paddel1.Bounds.Width && Ball1.Location.Y < Paddel1.Bounds.Y + Paddel1.Height && Ball1.Location.Y > Paddel1.Bounds.Y)
			{
				if (movementspeedBall2 > 0)
					movementspeedBall2 = (movementspeedBall2 + 1) * -1;
				else
					movementspeedBall2 = (movementspeedBall2 - 1) * -1;
			}
			//invertierung Paddel1
			
			if (Ball1.Location.X < 0) 
			{
				Score++;
				Ball1.Location = new Point(Game.Bounds.Width/2, Game.Bounds.Height/2);
				movementspeedBall2 = 4;
			}
			if (Ball1.Location.X > Game.Bounds.Width)
			{
				Score1++;
				Ball1.Location = new Point(Game.Bounds.Width / 2, Game.Bounds.Height / 2);
				movementspeedBall2 = 4;
			}
			//Ball zurück

			/*if (Ball1.Location.X > Game.Bounds.Width)
			{
				movementspeedBall2 = movementspeedBall2 * -1;
			}*/
		}
		private void Game_Paint(object sender, PaintEventArgs e)
		{
			label1.Text = Score1.ToString();
			label2.Text = Score.ToString();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			Startscreen.Hide();
			label4.Hide();
			timer.Start();
		}

		private void PongGame_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				upPressedP2 = true;
			}
			else if (e.KeyCode == Keys.Down)
			{
				downPressedP2 = true;
			}
			if (e.KeyCode == Keys.W)
			{
				upPressed = true;
			}
			else if (e.KeyCode == Keys.S)
			{
				downPressed = true;
			}
		}
		private void PongGame_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				upPressedP2 = false;
			}
			else if (e.KeyCode == Keys.Down)
			{
				downPressedP2 = false;
			}
			if (e.KeyCode == Keys.W)
			{
				upPressed = false;
			}
			else if (e.KeyCode == Keys.S)
			{
				downPressed = false;
			}	
		}
	}
}