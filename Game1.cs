using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Monogame_Scaling_and_text
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Random genorator;
        Texture2D rectangleTexture;
        Texture2D circleTexture;

        SpriteFont messageFont;

        Rectangle redRect, greenRect;

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
            genorator = new Random();
            redRect = new Rectangle(genorator.Next(5,200), genorator.Next(5, 200), genorator.Next(5, 500), genorator.Next(5, 500));
            greenRect = new Rectangle(genorator.Next(5, 200), genorator.Next(5, 200), genorator.Next(5, 500), genorator.Next(5, 500));
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");
            messageFont = Content.Load<SpriteFont>("Message Font");
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
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(rectangleTexture, redRect, Color.Red);
            _spriteBatch.Draw(circleTexture, greenRect, Color.Green);
            _spriteBatch.DrawString(messageFont, "Hello World", new Vector2(10,350), Color.Cornsilk);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}