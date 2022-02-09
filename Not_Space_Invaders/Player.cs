using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Space_Invaders
{
    class Player : Sprite
    {
        private int lives = 3;
        public Player(Texture2D intexture, Rectangle inposition, Color incolour) : base(intexture, inposition, incolour)
        { }
        public void Movement()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right) && spritePosition.X + spriteTexture.Width < GraphicsDeviceManager.DefaultBackBufferWidth)
            {
                spritePosition.X += 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left) && spritePosition.X > 0)
            {
                spritePosition.X -= 1;
            }
        }
    }
}
