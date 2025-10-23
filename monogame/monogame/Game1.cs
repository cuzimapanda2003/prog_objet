using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D background;
        private Texture2D shuttle;

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

            // TODO: use this.Content to load your game content here
            background = Content.Load<Texture2D>("images/stars");
            shuttle = Content.Load<Texture2D>("images/shuttle"); 

            //adapter l'écran a l'image si en vecteur
            //_graphics.IsFullScreen = false;
            //_graphics.PreferredBackBufferWidth = background.Width;
            //_graphics.PreferredBackBufferHeight = background.Height;
            //_graphics.ApplyChanges();

            //adapter l'image a l'écran
            _graphics.IsFullScreen = false;
            _graphics.PreferredBackBufferWidth = 1000;
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.ApplyChanges();


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Crimson);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            // Afficher image en vecteur
            // _spriteBatch.Draw(background, new Vector2(0, 0), Color.White);

            //image s'ajuste a l'écran
            _spriteBatch.Draw(background,
            new Rectangle(0, 0,_graphics.PreferredBackBufferWidth,_graphics.PreferredBackBufferHeight),
            Color.White);

            _spriteBatch.Draw(shuttle, new Vector2(100, 100), Color.White);
            _spriteBatch.Draw(shuttle, new Vector2(700, 100), Color.White);
            _spriteBatch.Draw(shuttle, new Vector2(100, 500), Color.White);
            _spriteBatch.Draw(shuttle, new Vector2(700, 500), Color.White);
            _spriteBatch.Draw(shuttle, new Vector2(429, 290), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
