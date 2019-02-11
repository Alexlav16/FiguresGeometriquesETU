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
	class Bullet : Movable
	{
		
	  public int ObjDmg { get; set; }

		public PlayerType PlayerType { get; set; }

		public Bullet(Vector2f position, uint nbSides, Color color, float speed, int objDmg, Vector2f direction, PlayerType playerType)
			: base(position, nbSides, color, speed)
		{
			SetPoint(0, new Vector2f(0, 0));
			SetPoint(1, new Vector2f(0, 4));
			SetPoint(2, new Vector2f(8, 4));
			SetPoint(3, new Vector2f(8, 0));
			Direction = direction;
			ObjDmg = objDmg;
			PlayerType = playerType;
		}

		public void Update()
		{

			Position = Position + (Direction * Speed);
			
		}
		
	}
}  
