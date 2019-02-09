using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;

namespace FiguresGeometriques
{
	class Drawable
	{
		ConvexShape shape = null;
		public Vector2f Position { get; set; }

		public Color Color { get { return shape.FillColor; } set { shape.FillColor = value; } }

		public virtual float Angle
		{
			get { return shape.Rotation; }
			set { shape.Rotation = value; }
		}

		protected Drawable(Vector2f position, uint nbSides, Color color)
		{
			Position = position;
			shape = new ConvexShape(nbSides);
			shape.FillColor = color;
			Angle = 0;
		}
		
		public Vector2f this[uint index]
		{
			get { return shape.GetPoint(index); }
			set { shape.SetPoint(index, value); }
		}

		public virtual void Draw(RenderWindow window)
		{
			shape.Position = Position;
			window.Draw(shape);
		}

		public FloatRect BoundingBox
		{
			get { return shape.GetGlobalBounds(); }
		}

		public bool Intersects(Drawable otherDrawable)
		{
			FloatRect rectangle = otherDrawable.BoundingBox;
			rectangle.Left = otherDrawable.Position.X;
			rectangle.Top = otherDrawable.Position.Y;
			return BoundingBox.Intersects(rectangle);
		}

		public bool Contains(Drawable otherDrawable)
		{
			return BoundingBox.Contains(otherDrawable.Position.X, otherDrawable.Position.Y);
		}

		protected void SetPoint(uint index, Vector2f pt)
		{
			shape.SetPoint(index, pt);
		}
	}
}
