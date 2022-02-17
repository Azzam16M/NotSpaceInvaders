using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Space_Invaders
{
    class Enemy : Sprite
    {
        private bool isDrawn;
        private Sprite otherSprite;

        public Enemy(Rectangle inPosition, Texture2D inTexture, Color inColour, bool inisDrawn, Sprite inotherSprite)
        :base(inTexture, inPosition, inColour)
        {
            isDrawn = inisDrawn;
            otherSprite = inotherSprite;
        }

        public bool  IsDrawn
        {
            get { return isDrawn; }
            set { isDrawn = value; }
        }

        public bool CheckCollided(Sprite inOtherSprite)
        {
            bool Collided = false;
            if (spritePosition.Intersects(inOtherSprite.Position))
            {
                Collided = true;
            }
            return Collided;

        }
    }
}
