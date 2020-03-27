using System.Drawing;

namespace Måltavla
{
	class Pil
	{
		private int x = 0;
		private int y = 0;
		private int radie = 0;
		public Pil(int x, int y, int r)
		{
			this.X = x;
			this.Y = y;
			this.Radie = r ;
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
		public int Radie
		{
			get
			{ return radie; }
			set
			{
				radie = value;
			}
		}
	/*	public Point Position
		{
			get { return new Point(x, y);}
			set { x = value.X;y = value.Y;}
		}*/

		//Rita kulhål
		public void Rita(Graphics g)
		{
			{
				g.FillEllipse(Brushes.Black, x - 5, y - 5, 5 * 2, 5 * 2);
				g.FillEllipse(Brushes.White, x - 3, y - 3, 3 * 2, 3 * 2);
			}
		}
	
		
	}
}
	

