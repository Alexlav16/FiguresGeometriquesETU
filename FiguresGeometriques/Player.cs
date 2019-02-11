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
	abstract class Player : Movable
	{

		public int Life { get; set; }

		public Vector2f playerpos { get; set; }
      
		public bool IsAlive
		{
			get { return Life > 0; }
			private set { }
		}
		
		public Player(Vector2f position, uint nbSides, Color color, float speed, int life)
			:base(position,nbSides,color,speed)
		{
			Life = life;
			SetPoint(0, new Vector2f(0, 38));
			SetPoint(1, new Vector2f(15, 53));
			SetPoint(2, new Vector2f(30, 38));
			SetPoint(3, new Vector2f(60, 30));
			SetPoint(4, new Vector2f(30, 23));
			SetPoint(5, new Vector2f(15, 8));
			SetPoint(6, new Vector2f(0, 23));
			SetPoint(7, new Vector2f(30, 30));
			shape.Origin = new Vector2f(10, 30);
		}

		public abstract void Update();
	}
}
