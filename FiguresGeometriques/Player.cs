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
			SetPoint(0, new Vector2f(0,0));
			SetPoint(1, new Vector2f(30, 10));
			SetPoint(2, new Vector2f(0, 20));	
		}

		public abstract void Update();
	}
}
