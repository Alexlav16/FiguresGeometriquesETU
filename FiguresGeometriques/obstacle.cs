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

		

	public int objdmg { get; set; }

		public Vector2f objposition
		{
			get { return objposition; }
			set { }	
				
		}




		public int Dmgdealt
		{
			get { return objdmg; }
			private set { }

		}


		public obstacle(Vector2f position, uint nbSides, Color color, float speed, int Objdmg)
			: base(position, nbSides, color, speed)
		{
			objdmg = Objdmg;

       SetPoint(0, new Vector2f(0, 0));
       SetPoint(1, new Vector2f(30, 0));
       SetPoint(2, new Vector2f(0, 30));
       SetPoint(3, new Vector2f(30, 30));
   Vector2f objposition = position;


   




		}

	}
}
