using System;
using System.Drawing;
using System.Windows.Forms;

namespace Måltavla
{
	public partial class Startknapp : Form
	{
		private Kulhål[] kulhåls;
		private int antalKulor = 0;
		private float a = 2;
		private bool[] träff = new bool[200];
		private int maxAntalKulor = 15;

		Måltavla mål = new Måltavla(0, 0, 0);
		Sikte sikte = new Sikte();
		public int raknare = 0;
		public int riktning=1;
		
		public Startknapp()
		{
			InitializeComponent();
			mål.X = ClientSize.Width / 2;
			mål.Y = ClientSize.Height / 2;
			mål.radie = 100;

			sikte.a = ClientSize.Width / 2;
			sikte.b = ClientSize.Height / 2;
			kulhåls = new Kulhål[200];
			Cursor myCursor = new Cursor("Sikte.cur");
			Cursor = myCursor;
			
		}
		//När timer tick sker : Slumpa riktning, slumpa antal rörelser, ändra måltavlekoordinater
		//och alla kulhålskoordinater och invalidejta.
		private void Timer1_Tick(object sender, EventArgs e)
		{
			Lblrnd.Text = Convert.ToString(maxAntalKulor - antalKulor);
			label4.Text = Convert.ToString(mål.Poäng);

			Random rndrörelser = new Random();
			if (raknare == 0)
			{
				Random rndriktning = new Random();
				riktning = rndriktning.Next(1, 5);

			}
			int antalSammaRiktning = rndrörelser.Next(5, 25);
			if (raknare < antalSammaRiktning)
			{
				raknare += 1;
				switch (riktning)
				{
					case 1: //vänster
						{
							if (mål.X > mål.radie)
							{
								mål.X -= 15;
								for (int i = 0; i < antalKulor; i++)
								{
									kulhåls[i].X -= 15;
								}
								Invalidate();
							}
							else
							{
								mål.X += 15;
								for (int i = 0; i < antalKulor; i++)
								{
									kulhåls[i].X += 15;
								}
								Invalidate();
								riktning = 2;
							}
						}
						break;
					case 2: //höger
						{
							if (mål.X < (ClientSize.Width - mål.radie))
							{
								mål.X += 15;
								for (int i = 0; i < antalKulor; i++)
								{
									kulhåls[i].X += 15;
								}
								Invalidate();
							}
							else
							{
								mål.X -= 15;
								for (int i = 0; i < antalKulor; i++)
								{
									kulhåls[i].X -= 15;
								}
								Invalidate();
								riktning = 1;
							}
						}
						break;
					case 3://upp
						{
							if (mål.Y > mål.radie)
							{
								mål.Y -= 15;
								for (int i = 0; i < antalKulor; i++)
								{
									kulhåls[i].Y -= 15;
								}
								Invalidate();
							}
							else
							{
								mål.Y += 15;
								for (int i = 0; i < antalKulor; i++)
								{
									kulhåls[i].Y += 15;
								}
								Invalidate();
								riktning = 4;
							}
						}
						break;
					case 4://ner
						{
							if (mål.Y < (ClientSize.Height - mål.radie))
							{
								mål.Y += 15;
								for (int i = 0; i < antalKulor; i++)
								{
									kulhåls[i].Y += 15;
								}
								Invalidate();
							}
							else
							{
								mål.Y -= 15;
								for (int i = 0; i < antalKulor; i++)
								{
									kulhåls[i].Y -= 15;
								}
								Invalidate();
								riktning = 3;
							}
						}
						break;

				}

			}
			else raknare = 0;
		}
		//Ritar Måltavla, Sikte, och Kulhål (om har skjutit någon träff)

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			mål.Rita(g);
			//sikte.Rita(g);
			for (int i = 0; i < antalKulor; i++)
			{
				if (kulhåls[i] != null && träff[i] == true)
				{
					kulhåls[i].Rita(e.Graphics);
				}
			}
		}
		
		//Ändra Sikteskoordinater till muskoordinater och invalidejtar
		protected override void OnMouseMove(MouseEventArgs e)
		{
			sikte.a = e.X;
			sikte.b = e.Y;
		}
		//Vid musknapp-nertryck spela upp ljud och gör rekylloop med siktet
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (antalKulor < maxAntalKulor)
			{
				kulhåls[antalKulor++] = new Kulhål(e.X, e.Y, a);
				if (mål.TavlanTräffad(e.X, e.Y)) 
				{
					träff[antalKulor - 1] = true;
					System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Skott.wav");
					player.Play();
					if (mål.Bullseye1 == true)
					{
						System.Media.SoundPlayer players = new System.Media.SoundPlayer(@"SkottnHit.wav");
						players.Play();mål.Bullseye1 = false;
					}
				}
				else
				{
					System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Miss.wav");
					player.Play();
				}

			}
			else
			{
				System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Click.wav");
				player.Play();
				LblY.Text = "Out of ammo!";
			}
					for (int i = 1; i < 17; i+=2)
				{
				sikte.a = e.X-1;
				sikte.b = e.Y - i;
				Invalidate();
				}		
		}
		
		
		// tar emot inklickad radie på måltavlan då knappen clickas - invalidejtar
		private void UpDown_ValueChanged(object sender, EventArgs e)
		{
			float radienFöre = mål.radie;
			//double kulradien = (double)kulhåls[antalKulor].Radie;
			mål.radie = 20 * Convert.ToInt32(UpDown.Value+1);	
			a = (float)UpDown.Value-2;
			//Uträkning av ny position och storlek för kulorna efter förstoring/minskning
			float Procent = (mål.radie/ radienFöre);
			float Xskillnad;
			float Yskillnad;
			
			for (int i = 0; i < antalKulor; i++)
			{
				if (träff[i] == true)
				{
					Xskillnad = kulhåls[i].X-mål.X;
					Yskillnad = kulhåls[i].Y-mål.Y;
					float svarX = Xskillnad *= Procent;
					float svarY = Yskillnad *= Procent;
					kulhåls [i].X = mål.X+Convert.ToInt32(Math.Round(svarX));
					kulhåls[i].Y = mål.Y+Convert.ToInt32(Math.Round(svarY));
					kulhåls[i].Radie = a;
				}
			}
			
			Invalidate();
		}
		private void BtnRestart_Click(object sender, EventArgs e)
		{
			if (antalKulor == maxAntalKulor)
			{
				Application.Restart();
				Environment.Exit(0);
			}
		}

		private void UpDownSpeed_ValueChanged(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			int a = Convert.ToInt32(UpDownSpeed.Value);
			int tid = 5;
			for (int j=10; j > a; j--) 
			{
				tid += 10;
			}
			if (tid > 0) timer1.Interval = tid;
			timer1.Enabled = true;
		}
	}
}
