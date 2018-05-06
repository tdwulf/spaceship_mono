using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceShip.Desktop
{
    public class Asteroid
    {

        public Vector2 position;

        public int speed;
        public int radius = 59;
        public bool offScreen = false;

        static Random rand = new Random();

        public void asteroidUpdate(GameTime gameTime){
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * dt;
        }

        public Asteroid(int newSpeed) {
            speed = newSpeed;
            position = new Vector2(1024+radius,rand.Next(radius, 680-radius));
        }


    }
}
