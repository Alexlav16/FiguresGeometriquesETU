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
		public const int NUMBER_STARS = 150;
		private static Random rand = new Random();

		private RenderWindow window = null;
    private Color backgroundColor = Color.Black;
		private Font font = new Font("arial.ttf");
		private Text healthText1 = new Text();
		private Text healthText2 = new Text();

    private Player player1 = new Player1(new Vector2f(100, 100), 8, Color.Blue, 5.5f, 200);
		private Player player2 = new Player2(new Vector2f(WIDTH - 100, HEIGHT - 100), 8, Color.Yellow, 5.5f, 200);
		private List<Obstacle> obstacles = new List<Obstacle>();
		private List<Bullet> bullets = new List<Bullet>();
		private List<Star> stars = new List<Star>();

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
      obstacles.Add(new Obstacle(new Vector2f(150,150),4,Color.Red,0,1));
			healthText1.Font = font;
			healthText1.DisplayedString = "Health: " + player1.Life;
			healthText1.Color = Color.White;
			healthText1.Position = new Vector2f(20, 20);
			healthText2.Font = font;
			healthText2.DisplayedString = "Health: " + player2.Life;
			healthText2.Color = Color.White;
			healthText2.Position = new Vector2f(WIDTH - 200, 20);
			for(int i = 0; i <NUMBER_STARS; ++i)
			{
				stars.Add(new Star(rand.Next(0, WIDTH - 1), rand.Next(0,HEIGHT - 1), (float)rand.NextDouble()));
			}
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
			foreach(Obstacle o in obstacles)
			{
				o.Draw(window);
			}

			foreach(Star s in stars)
			{
				s.Draw(window);
			}

			foreach(Bullet b in bullets)
			{
				b.Draw(window);
			}

			player1.Draw(window);
			player2.Draw(window);

			window.Draw(healthText1);
			window.Draw(healthText2);
    }

    public bool Update()
    {
      player1.Update(this);
			player2.Update(this);


			foreach (Bullet b in bullets)
			{
				if (b.Intersects(player1))
				{
					player1.Life -= b.ObjDmg;
					healthText1.DisplayedString = "Health: " + player1.Life;
				}

				if (b.Intersects(player2))
				{
					player2.Life -= b.ObjDmg;
					healthText2.DisplayedString = "Health: " + player2.Life;
				}

			}
			foreach (Obstacle o in obstacles)
			{
				if (o.Intersects(player1)) 
				{
					player1.Life -= o.objdmg;
					healthText1.DisplayedString = "Health: " + player1.Life;
				}

				if (o.Intersects(player2))
				{
					player2.Life -= o.objdmg;
					healthText2.DisplayedString = "Health: " + player2.Life;
				}


			}

			foreach(Star s in stars)
			{
				s.Update(player1.Direction);
			}

			foreach(Bullet b in bullets)
			{
				b.Update();
			}

      if (!player1.IsAlive || !player2.IsAlive)
			{
				return false;
			}
			return true;
		}

		public void AddBullet(Bullet bullet)
		{
			bullets.Add(bullet);
		}
   
  }
}
