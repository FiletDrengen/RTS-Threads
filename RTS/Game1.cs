using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RTS
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch spriteBatch;


        private Texture2D House1;
        private Texture2D House2;
        private Texture2D Miner1;
        private Texture2D Miner2;
        private Texture2D Miner3;
        private Texture2D Miner4;
        private Texture2D Crystal;
        private Texture2D Rock;

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
            spriteBatch = new SpriteBatch(GraphicsDevice);
            House1 = Content.Load<Texture2D>("1House");
            House2 = Content.Load<Texture2D>("2House");
            Miner1 = Content.Load<Texture2D>("1Player");
            Miner2 = Content.Load<Texture2D>("2Player");
            Miner3 = Content.Load<Texture2D>("3Player");
            Miner4 = Content.Load<Texture2D>("4Player");
            Crystal = Content.Load<Texture2D>("1Crystal");
            Rock = Content.Load<Texture2D>("1Rock");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
