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
	class Obstacle : Movable  
	{

		public int ObjDmg { get; set; }

		public Obstacle(Vector2f position, uint nbSides, Color color, float speed, int objDmg)
			: base(position, nbSides, color, speed)
		{
			ObjDmg = objDmg;

      SetPoint(0, new Vector2f(0, 0));
      SetPoint(1, new Vector2f(30, 0));
      SetPoint(2, new Vector2f(30, 30));
      SetPoint(3, new Vector2f(0, 30));
		}

	}
}
