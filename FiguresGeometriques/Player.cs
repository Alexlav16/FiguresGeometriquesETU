using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;

namespace FiguresGeometriques
{
	class Player
	{
		int life = 0;
		float speed = 0.0f;
		Vector2f position = new Vector2f(0, 0);
		ConvexShape shape = null;

		public Player(int life, float speed, Vector2f position)
		{
			this.life = life;
			this.speed = speed;
			this.position = position;
			shape = new ConvexShape();
			shape.SetPointCount(3);
			shape.SetPoint(0, new Vector2f(position.X, position.Y));
			shape.SetPoint(1, new Vector2f(position.X + 20,position.Y - 60));
			shape.SetPoint(2, new Vector2f(position.X + 40, position.Y));
			shape.FillColor = Color.Blue;
		}

		public void Draw(RenderWindow window)
		{
			window.Draw(shape);
		}

		public void Update()
		{

		}

		public void Move()
		{

		}
	}
}
