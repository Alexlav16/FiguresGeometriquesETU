﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace FiguresGeometriques
{
	class Player2 : Player
	{
		public Player2(Vector2f position, uint nbSides, Color color, float speed, int life)
			: base(position, nbSides, color, speed, life)
		{

		}

		public override void Update(Application application)
		{
			if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
			{
				Move(Speed);
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
			{
				Move(-Speed);
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.Left))
			{
				Rotate(-5);
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.Right))
			{
				Rotate(5);
			}
			if (Keyboard.IsKeyPressed(Keyboard.Key.Numpad0) && (DateTime.Now - lastTimeFired).TotalMilliseconds > FIRE_DELAY)
			{
				application.AddBullet(new Bullet(Position, 4, Color.Cyan, 50.0f, 1, Direction, PlayerType.PLAYER_TWO));
				lastTimeFired = DateTime.Now;
			}

			if (Position.X < 0)
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
