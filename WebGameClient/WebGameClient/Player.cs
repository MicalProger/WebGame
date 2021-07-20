using Self2D;
using SFML.Graphics;
using SFML.Graphics.Glsl;
using SFML.System;

namespace WebGameClient
{
    public class Player
    {
        public Player(Point2 pos, Color c)
        {
            Position = pos;
            Color = c;
            View.startPos = Position;
        }
        
        public Point2 Position;

        public Color Color;

        public Rectangle View = new Rectangle(Point2.Zero, new Vector2f(50, 50), Color.Cyan);
    }
}