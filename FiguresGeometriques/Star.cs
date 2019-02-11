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
	public class Star
	{
		public const int STAR_WIDTH = 4;
		public const int STAR_HEIGHT = 4;
		private static Color[] colors = new Color[] { Color.Yellow, Color.White, Color.Red };
		private static RectangleShape shape;
		private static Random rnd = new Random();
		private int colorType;

		public float PositionX
		{
			get; set;
		}

		public float PositionY
		{
			get; set;
		}

		public float Speed
		{
			get; set;
		}

		public Star(float posX, float posY, float speed)
		{
			PositionX = posX;
			PositionY = posY;
			Speed = speed + (float)rnd.NextDouble();
			shape = new RectangleShape(new Vector2f(STAR_WIDTH, STAR_HEIGHT));
			colorType = rnd.Next(0, colors.Length);
			shape.FillColor = colors[colorType];
		}

		public void Draw(RenderWindow window)
		{
			shape.Position = new Vector2f(PositionX, PositionY);
			shape.FillColor = colors[colorType];
			window.Draw(shape);
		}


		public void Update(Vector2f direction)
		{
			if (Keyboard.IsKeyPressed(Keyboard.Key.W))
			{
				PositionX = PositionX + direction.X * Speed;
				PositionY = PositionY + direction.Y * Speed;
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.S))
			{
				PositionX = PositionX + direction.X * -Speed;
				PositionY = PositionY + direction.Y * -Speed;
			}

			Respawn();
		}

		public void Respawn()
		{
			if (PositionX < 0)
			{
				PositionX = Application.WIDTH - 1;
			}
			else if (PositionX >= Application.WIDTH)
			{
				PositionX = 0;
			}
			else if (PositionY < 0)
			{
				PositionY = Application.HEIGHT - 1;
			}
			else if (PositionY >= Application.HEIGHT)
			{
				PositionY = 0;
			}
		}

	}
}
