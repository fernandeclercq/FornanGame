using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Threading;

namespace FornanGame
{
    public class Game1 : Game
    {
        private const string ASSET_NAME_SPRITESHEET = "CharacterSpriteSheet_4";
        private Texture2D _texture;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle _partSpriteSheet;
        Vector2 drawingPoint;

        int Y_position = 0; //vertical line
        int X_position = 0; //horizontal line
        int width = 50;
        int height = 75;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            Window.AllowUserResizing = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _partSpriteSheet = new Rectangle(X_position, Y_position, width, height);
            drawingPoint = new Vector2(0, 0);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _texture = Content.Load<Texture2D>(ASSET_NAME_SPRITESHEET);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            X_position += 50;

            if (X_position > 200)
            {
                X_position = 0;
            }
            _partSpriteSheet.X = X_position;

            base.Update(gameTime);

            
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Cyan);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(_texture, drawingPoint, _partSpriteSheet, Color.White);

            

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
