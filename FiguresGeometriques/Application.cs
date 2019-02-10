using System;
using SFML;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System.Collections.Generic;

namespace FiguresGeometriques
{
  class Application
  {

		public const int WIDTH = 1024;
		public const int HEIGHT = 768;
		public const uint FRAME_LIMIT = 60;

		private RenderWindow window = null;
		private Color backgroundColor = Color.Black;

		private Player player = new Player(new Vector2f(100, 100), 3, Color.Blue, 5.5f, 1);
		private List<Drawable> drawables = new List<Drawable>();

    private void OnClose(object sender, EventArgs e)
    {
      RenderWindow window = (RenderWindow)sender;
      window.Close();
    }

		private void OnKeyPressed(object sender, KeyEventArgs e)
		{
			
		}

    public Application(string windowTitle, uint width, uint height)
    {
      window = new RenderWindow(new SFML.Window.VideoMode(WIDTH, HEIGHT), windowTitle);
      window.Closed += OnClose;
			window.KeyPressed += new EventHandler<KeyEventArgs>(OnKeyPressed);
			window.SetFramerateLimit(FRAME_LIMIT);
			drawables.Add(player);
		}


    public void Run()
    {
      window.SetActive();

      while (window.IsOpen)
      {
        window.Clear(backgroundColor);
        window.DispatchEvents();
				if(!Update())
				{
					break;
				}
        Draw();
        window.Display();			
			}
    }

    public void Draw()
    {
			foreach(Drawable d in drawables)
			{
				d.Draw(window);
			}
    }

		public bool Update()
		{
			player.Update();
			if(!player.IsAlive)
			{
				return false;
			}
			return true;
		}
  }
}
