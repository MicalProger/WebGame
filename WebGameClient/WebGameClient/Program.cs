using System;
using SFML.Graphics;
using Self2D;
using SFML.System;
using SFML.Window;

namespace WebGameClient
{
    class Program
    {
        private static Player localPlayer;
        private static Grid _grid;
        private static RenderWindow _window;
        static void Main(string[] args)
        { 
            localPlayer = new Player(new Point2(20, 20), Color.Green);
            localPlayer.Color = Color.Cyan;
            localPlayer.Position = new Point2(20, 20);
            _grid = new Grid(500, 500);
            _grid.AddPrim(localPlayer.View);
            _window = new RenderWindow(new VideoMode(500, 500), "Game");
            _window.SetVerticalSyncEnabled(true);
            _window.Closed += (sender, eventArgs) => _window.Close();
            _window.SetActive(true);
            while (_window.IsOpen)
            {
                _window.DispatchEvents();
                _window.Clear(new(0, 0, 0));
                KeyHandler();
                {
                    localPlayer.View.startPos = localPlayer.Position;
                }
                _grid.ShowToScreen(_window);
                _window.Display();
            }
        }

        public static void KeyHandler()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                localPlayer.Position += new Point2(0, -5);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                localPlayer.Position += new Point2(0, 5);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                localPlayer.Position += new Point2(-5, 0);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                localPlayer.Position += new Point2(5, 0);
            }
        }
    }
}