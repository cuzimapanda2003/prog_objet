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
        Sprite nutz2;
        SpriteTouches player;

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
            
            nutz1.vitesseMarche = 0.9f;
            nutz1.direction = Vector2.One;
            
            nutz2 = new Sprite(texturenutz, new Vector2 (10, 10));
            nutz2.direction = Vector2.UnitY;
            nutz2.vitesseMarche = 0.55f;

            player = new SpriteTouches(texturenutz, new Vector2(10, 10));
            player.vitesseMarche = 2f;
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //nutz1.position.X += 1f;
            //nutz1.position.Y += 1f;
            player.Update(gameTime);
            nutz1.Update(gameTime);
            nutz2.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue); // permet d'effacer a chaque fois que tu affiche sinon nian cats

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

          
            //_spriteBatch.Draw(nutz1.texture, nutz1.position, Color.White); // dessin de depart sans class

            nutz1.Draw(gameTime, _spriteBatch);
            nutz2.Draw(gameTime, _spriteBatch);
            player.Draw(gameTime, _spriteBatch);



            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
