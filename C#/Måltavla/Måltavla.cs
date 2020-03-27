using System.Drawing;
namespace Måltavla
{
	class Måltavla
	{
		private int x = 0;
		private int y = 0;
		public int radie = 0;
		public int Poäng = 0;
		private bool Bullseye = false;
		public Måltavla(int x, int y, int r)
		{
			this.X = x;
			this.Y = y;
			this.radie = r;
		}

		public int X
		{
			get
			{ return x; }
			set
			{
				x = value;
			}
		}
		public int Y
		{
			get
			{ return y; }
			set
			{
				y = value;
			}
		}

		public bool Bullseye1 { get => Bullseye; set => Bullseye = value; }

		public void Rita(Graphics g)
		{
			int r = radie;
			g.FillEllipse(Brushes.White, x - r, y - r, r * 2, r * 2);
			r = (int)(radie * 0.8);

			SolidBrush halvgrå = new SolidBrush(Color.FromArgb(225,0, 0,0));
			g.FillEllipse(halvgrå, x - r, y - r, r * 2, r * 2);
			
			r = (int)(radie * 0.6);
			g.FillEllipse(Brushes.Blue, x - r, y - r, r * 2, r * 2);
			r = (int)(radie * 0.4);
			g.FillEllipse(Brushes.Red, x - r, y - r, r * 2, r * 2);
			r = (int)(radie * 0.2);
			g.FillEllipse(Brushes.Yellow, x - r, y - r, r * 2, r * 2);
			g.DrawEllipse(Pens.Black, x - radie, y - radie, radie * 2, radie * 2);
		}
		public bool TavlanTräffad(int musX, int musY)
		{
			bool träffad = false;
			int dx = musX - (x);
			int dy = musY - (y);
			int ds2 = dx * dx + dy * dy;
			if (ds2 < radie * radie && ds2 > (radie * 0.8) * (radie * 0.8)) Poäng += 10;
			if (ds2 < (radie * 0.8) * (radie * 0.8) && ds2 > (radie * 0.6) * (radie * 0.6)) Poäng += 20;
			if (ds2 < (radie*0.6) * (radie*0.6) && ds2 > (radie * 0.4) * (radie * 0.4)) Poäng += 30;
			if (ds2 < (radie * 0.4) * (radie * 0.4) && ds2 > (radie * 0.2) * (radie * 0.2)) Poäng += 40;
			if (ds2 < (radie * 0.2) * (radie * 0.2) && ds2 >= (0) * (0))
			{
				Poäng += 60;
				Bullseye1 = true;
			}
			if (ds2 < radie * radie)
			{
				träffad = true;
			}
			return träffad;
		}
	}
}
