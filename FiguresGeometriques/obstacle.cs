using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;


namespace FiguresGeometriques
{
	class obstacle : Movable
	{

		int objdmg = 2;

		public obstacle(Vector2f position, uint nbSides, Color color, float speed, int Objdmg)
			: base(position, nbSides, color, speed)
		{
			objdmg = Objdmg;



		}

	}
}
