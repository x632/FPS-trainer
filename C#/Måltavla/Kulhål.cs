
using System.Drawing;
namespace Måltavla
{
	class Kulhål
	{
		private int x = 0;
		private int y = 0;
		public float radie = 0;
		public Kulhål(int x, int y, float r)
		{
			this.X = x;
			this.Y = y;
			this.Radie = r;
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
		public float Radie
		{
			get
			{ return radie; }
			set
			{
				radie = value;
			}
		}
		//Rita kulhål
		public void Rita(Graphics g)
		{
			{
				g.FillEllipse(Brushes.White, x - Radie / 2-2, y - Radie / 2-2, Radie * 2+2, Radie * 2+2);
				Pen pens = new Pen(Color.Black, 1f);
				g.DrawEllipse(pens, x - Radie/2-3, y-Radie/2-3, Radie*2+3, Radie*2+3);
			}
		}


	}
}
	

