using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Project1
{
    public class Sprite
    {
        public Vector2 position = Vector2.Zero; // new Vector2(0, 0);
        public Rectangle destRect = Rectangle.Empty; //new rectangle(0,0,0,0);
        public Vector2 origine = new Vector2(0, 0);
        public float rotation = 0f;
        public float scale = 3f;
        public SpriteEffects spriteEffects = SpriteEffects.None;
        public int layerdepth = 1;
        private Color color = Color.White;
        public Texture2D texture;


        public Sprite(Texture2D texture,Vector2 position)
        {
           this.position = position;
            
            this.texture = texture; 
            this.destRect.X =(int)position.X;
            this.destRect.Y =(int)position.Y;
            this.destRect.Width = texture.Width;
            this.destRect.Height = texture.Height;

        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(texture, position, color);
        }
    }
}
