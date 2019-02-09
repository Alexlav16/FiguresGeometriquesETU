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
    private RenderWindow window = null;
		private Color backgroundColor = Color.Black;
		private Player player = new Player(3, 5.5f, new Vector2f(100, 100));

    private void OnClose(object sender, EventArgs e)
    {
      RenderWindow window = (RenderWindow)sender;
      window.Close();
    }

		private void KeyPressed(object sender, KeyEventArgs e)
		{
			if(e.Code == Keyboard.Key.W)
			{
				player.Move();
			}

			if(e.Code == Keyboard.Key.A)
			{
				player.Rotate(5);
			}

			if(e.Code == Keyboard.Key.S)
			{
				player.Rotate(-5);
			}
		}

    public Application(string windowTitle, uint width, uint height)
    {
      window = new RenderWindow(new SFML.Window.VideoMode(width, height), windowTitle);
      window.Closed += new EventHandler(OnClose);
    }


    public void Run()
    {
      window.SetActive();

      while (window.IsOpen)
      {
        window.Clear(backgroundColor);
        window.DispatchEvents();
        Draw(window);
        window.Display();
				
				
			}
    }

    public void Draw(RenderWindow window)
    {
			player.Draw(window);





    }
  }
}
