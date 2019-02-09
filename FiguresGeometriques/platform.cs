using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;


namespace FiguresGeometriques
{
	class Platform
	{

		private int height = 5;
		private int width = 5;
		private Vector2f position = new Vector2f(0, 0);
		RectangleShape rect;

		public Platform(Vector2f position)
		{
			this.position = position;
			
			rect = new RectangleShape();
			rect.FillColor = Color.Red;
			
			
		}
		


		




	}
}
