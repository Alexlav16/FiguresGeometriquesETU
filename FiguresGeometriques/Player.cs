using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace FiguresGeometriques
{
	class Player : Movable
	{
		public int Life { get; set; }
		
		public Player(Vector2f position, uint nbSides, Color color, float speed, int life)
			:base(position,nbSides,color,speed)
		{
			Life = life;
			SetPoint(0, new Vector2f(0,0));
			SetPoint(1, new Vector2f(30, 10));
			SetPoint(2, new Vector2f(0, 20));
		}

		public void Update()
		{

			if (Keyboard.IsKeyPressed(Keyboard.Key.W))
			{
				Move(Speed);
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.S))
			{
				Move(-Speed);
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.A))
			{
				Rotate(-5);
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.D))
			{
				Rotate(5);
			}

			if (Position.X < 0 )
			{
				Position = new Vector2f(Application.WIDTH - 1, Position.Y);
			}
			else if (Position.X > Application.WIDTH - 1)
			{
				Position = new Vector2f(0, Position.Y);
			}

			if (Position.Y < 0)
			{
				Position = new Vector2f(Position.X, Application.HEIGHT - 1);
			}
			else if (Position.Y > Application.HEIGHT - 1)
			{
				Position = new Vector2f(Position.X, 0);
			}
		}
	}
}
