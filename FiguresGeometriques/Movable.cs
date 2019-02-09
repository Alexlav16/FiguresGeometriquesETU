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
	class Movable : Drawable
	{

		public override float Angle
		{
			get
			{
				return base.Angle;
			}

			set
			{
				base.Angle = value;
				Direction = new Vector2f((float)Math.Cos(Math.PI * Angle / 180.0f), (float)Math.Sin(Math.PI * Angle / 180.0f));
			}
		}
		public float Size { get { return Math.Max(BoundingBox.Height, BoundingBox.Width); } }

		public Vector2f Direction { get; set; }

		public float Speed { get; set; }

		public Movable(Vector2f position, uint nbSides, Color color, float speed)
			: base(position,nbSides,color)
		{
			Angle = 0;
			Speed = speed;
		}

		public void Move(float speed)
		{
			Position = Position + Direction * speed;
		}

		public void Rotate(float angleInDegrees)
		{
			Angle += angleInDegrees;
		}

	}
}
