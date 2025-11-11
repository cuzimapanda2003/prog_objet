using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D texturenutz;// image étape 1

        Sprite nutz1;

        // bouger étape 1

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
           

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // image étape 2
            texturenutz = Content.Load<Texture2D>("Images/nutz_stationnairedroite");
            nutz1 = new Sprite(texturenutz, new Vector2(10, 10));
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            nutz1.position.X += 0.2f;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();


  

            //  _spriteBatch.Draw(texturenutz,position_nutz1, color);
            //  texture,position x,y écran coin gauche image,null:toute l'imgae, rotation (0f
            //  )new vector( origine pour rotation), scale 3f grossit 3 fois, pas d'effet,  1 ne sert pas :profondeur
            // _spriteBatch.Draw(texturenutz, nutz1.position, null ,Color.White);

            nutz1.Draw(_spriteBatch);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
