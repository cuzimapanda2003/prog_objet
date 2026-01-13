using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project1
{
    internal class SpriteTouches : Sprite
    {
        public SpriteTouches(Texture2D texture, Vector2 position)
            : base(texture, position)
        {
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();

            direction = Vector2.Zero;

            if (ks.IsKeyDown(Keys.Left))
                direction.X = -1;
            if (ks.IsKeyDown(Keys.Right))
                direction.X = 1;
            if (ks.IsKeyDown(Keys.Up))
                direction.Y = -1;
            if (ks.IsKeyDown(Keys.Down))
                direction.Y = 1;

            // Normaliser direction (évite vitesse double en diagonale)
            if (direction != Vector2.Zero)
                direction.Normalize();

            base.Update(gameTime); // déplace réellement selon direction et vitesse
        }
    }
}
