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
        private Texture2D feuilleMario;
        private Texture2D earth;

        // au lieu de faire des new Vector2 dans le spriteBatch.Draw
        private Vector2 positionEarth = new Vector2(300, 500);
        private Vector2 origineearth;
        private float rotationearth = 0.2f;
        

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
            feuilleMario = Content.Load<Texture2D>("images/FeuilleDeMarios");
            earth = Content.Load<Texture2D>("images/earth");

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
            origineearth = new Vector2(earth.Width / 2f, earth.Height / 2f);



        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            rotationearth += .1f;

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

            _spriteBatch.Draw(shuttle, new Vector2(100, 100),new Rectangle(0,0,shuttle.Width/2,shuttle.Height) ,Color.White);
            _spriteBatch.Draw(shuttle, new Vector2(700, 100), Color.White);
            _spriteBatch.Draw(shuttle, new Vector2(429, 290), new Rectangle(0, 0, shuttle.Width, shuttle.Height / 2), Color.White);
           
            _spriteBatch.Draw(feuilleMario,
               new Rectangle
               (_graphics.PreferredBackBufferWidth - ((feuilleMario.Width / 4)*2),
               _graphics.PreferredBackBufferHeight - ((feuilleMario.Height / 4)*2),
               (feuilleMario.Width / 4)*2,
               (feuilleMario.Height / 4)*2),
               new Rectangle(0,0,feuilleMario.Width / 4, feuilleMario.Height / 4),
               Color.White);

            _spriteBatch.Draw(
                earth,
                new Vector2((int)positionEarth.X + 100, (int)positionEarth.Y - 100),
               null,
               Color.White,
               rotationearth,       
               origineearth,
               0.5f,
               SpriteEffects.FlipVertically,
               1
);

 _spriteBatch.Draw(feuilleMario, new Vector2(429, 0),new Rectangle(0,0,feuilleMario.Width / 4, feuilleMario.Height / 4) ,Color.Red);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
