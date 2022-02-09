using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Space_Invaders
{
    class Enemyships : Sprite
    {
        private bool moveRight, moveLeft;
        private Enemy[,] enemyArray;
        private const int SPACE_BETWEEN_SHIPS = 10;
        private Sprite otherSprite;

        public Enemyships(Rectangle inPosition, Texture2D inTexture, Color inColour, Enemy[,] inEnemyArray, Sprite inotherSprite)
        : base(inTexture, inPosition, inColour)
        {
            enemyArray = inEnemyArray;
            otherSprite = inotherSprite;
        }

        public void InitialiseEnemyShips()
        {
            for (int i = 0; i <= enemyArray.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= enemyArray.GetUpperBound(1); j++)
                {
                    enemyArray[i, j] = new Enemy(new Rectangle((i * spriteTexture.Width) + (i * SPACE_BETWEEN_SHIPS),
                                                             (j * spriteTexture.Height) + (j * SPACE_BETWEEN_SHIPS),
                                                             spriteTexture.Width, spriteTexture.Height), spriteTexture, Color.White,
                                                             true, otherSprite);
                }
            }
        }
        public void Movement(GraphicsDeviceManager inGraphics)
        {
            for (int i = 0; i <= enemyArray.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= enemyArray.GetUpperBound(1); j++)
                {
                    if (enemyArray[enemyArray.GetUpperBound(0), j].Position.X + enemyArray[enemyArray.GetUpperBound(0), j].Texture.Width
                    >= inGraphics.PreferredBackBufferWidth)
                    {
                        moveLeft = true;
                        moveRight = false;
                    }
                    if (enemyArray[0, j].Position.X <= 0)
                    {
                        moveLeft = false;
                        moveRight = true;
                    }
                }
            }

            foreach (Enemy e in enemyArray)
            {
                if (moveRight)
                {
                    e.Position = new Rectangle(e.Position.X + 1, e.Position.Y, Texture.Width, Texture.Height);
                }
                if (moveLeft)
                {
                    e.Position = new Rectangle(e.Position.X + 1, e.Position.Y, Texture.Width, Texture.Height);
                }
            }
        }
    }
}

// more collisions
 
 






