using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;


namespace Project1
{
    public class Sprite
    {
        public Texture2D texture { get; set; }
        public Color color {  get; set; } = Color.White;
        public SpriteEffects spriteEffects {  get; set; } = SpriteEffects.None;
        
        public float rotation {  get; set; } = 0f;
        public float scale { get; set; } = 1f;

        public int layerdepth { get; set; } = 1;

        public float vitesseMarche { get; set; } = 0.5f;

        public Rectangle RectBounds { get; set; }


        public Vector2 position = new Vector2(0, 0);// init ici ok si valeur fixe
        public Rectangle destRect = new Rectangle(0, 0, 50, 50);
        public Vector2 origine = Vector2.Zero;// meme chose que new vector2(0,0)

      
       
        
        
        public Vector2 direction = Vector2.Zero; //(0,0)

        public Sprite()
        {
            RectBounds = new Rectangle(0, 0, 800, 480);
        }

        public Sprite(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
            RectBounds = new Rectangle(0, 0, 800, 480);
        }

        public Sprite(Texture2D texture, Vector2 position, Rectangle bounds)
        {
            this.texture = texture;
            this.position = position;
            this.RectBounds = bounds;
        }

        public virtual void Update(GameTime gameTime)
        {
            position.X += vitesseMarche * direction.X;
            position.Y += vitesseMarche * direction.Y;

          
            position.X = Math.Clamp(position.X, RectBounds.Left, RectBounds.Right - destRect.Width);
            position.Y = Math.Clamp(position.Y, RectBounds.Top, RectBounds.Bottom - destRect.Height);

            destRect.X = (int)position.X;
            destRect.Y = (int)position.Y;
        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                texture,
                destRect,
                null,
                color
                );

        }

 
    }
}