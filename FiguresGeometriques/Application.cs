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
    

    private void OnClose(object sender, EventArgs e)
    {
      RenderWindow window = (RenderWindow)sender;
      window.Close();
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
        Draw();
        window.Display();
      }
    }

    public void Draw()
    {
      





    }
  }
}
