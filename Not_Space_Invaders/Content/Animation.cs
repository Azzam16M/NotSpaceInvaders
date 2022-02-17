using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Space_Invaders.Content
{
    class Animation : Sprite
    {
        private int frames;
        private float timeElapsed, timeToUpdate;
        private bool isLooping = false;

        private Vector2 origin;
        private float rotation = 0.0f;
        private float scale = 0.0f;
        private SpriteEffects spriteEffects;
        private Rectangle[] rectangles;
        private int frameIndex = 0;

        public Animation(Rectangle inPosition, Texture2D inTexture, Color inColour, int inframes)
            : base(inTexture, inPosition, inColour)
        {
            spriteTexture = inTexture;
            int width = inTexture.Width / inframes;
            rectangles = new Rectangle[inframes];

            for (int i = 0; i < inframes; i++)
            {
                rectangles[i] = new Rectangle(i * width, 0, width, spriteTexture.Height / 2);
            }
        }

        public int FPS
        {
            set { timeToUpdate = (1f / value); }
        }

        public void Update(GameTime inGameTime)
        {
            //timeElapsed += (float)inGameTime.ElaspedGameTime.TotalSeconds;

            if(timeElapsed > timeToUpdate)
            {
                timeElapsed -= timeToUpdate;

                if (frameIndex < rectangles.Length - 1)
                {
                    frameIndex++;
                }
                else if (isLooping)
                {
                    frameIndex = 0;
                }

            }


        }





    }
}
