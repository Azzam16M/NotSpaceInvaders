﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Space_Invaders
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D myTexture;
        private Texture2D BulletTexture;
        private Player player1;
        private Bullet player1Bullet;
        int xPosition = 327;
        int yPosition = 427;
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
            player1Bullet.InitialPosition(player1);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            myTexture = Content.Load<Texture2D>("Brick");
            BulletTexture = Content.Load<Texture2D>("Bullet");
            player1 = new Player(myTexture, new Rectangle(xPosition, yPosition, myTexture.Width, myTexture.Height), Color.BlanchedAlmond);
            player1Bullet = new Bullet(BulletTexture, new Rectangle(xPosition, yPosition, BulletTexture.Width, BulletTexture.Height), Color.Red);

            player1Bullet.InitialPosition(player1);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            player1.Movement();
            player1Bullet.FireBullet(player1);



            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            player1.DrawSprite(_spriteBatch);
            player1Bullet.DrawSprite(_spriteBatch);

          

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}