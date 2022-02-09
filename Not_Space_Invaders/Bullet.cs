using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Space_Invaders
{
    class Bullet : Sprite
    {
        private int xPosition;
        private int yPosition;
        private bool fired = false;

        public Bullet(Texture2D intexture, Rectangle inposition, Color incolour) : base(intexture, inposition, incolour)
        {
            //constructor
        }

        public void InitialPosition(Sprite inSprite)
        {
            xPosition = inSprite.Position.X + inSprite.Texture.Width / 2 - Texture.Width / 2;
            spritePosition = new Rectangle(xPosition, inSprite.Position.Y + 2, Texture.Width, Texture.Height);
            yPosition = spritePosition.Y;       
        }

        public void FireBullet(Sprite inSprite)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                fired = true;
            }

            if (spritePosition.Y > 0 && fired)
            {
                spritePosition = new Rectangle(xPosition, yPosition, Texture.Width, Texture.Height);
                yPosition -= 1;
            }
            else
            {
                InitialPosition(inSprite);
                fired = false;
            }


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        

        }
    }
}