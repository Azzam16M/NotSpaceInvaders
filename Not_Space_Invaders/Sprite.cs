using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Not_Space_Invaders
{
    class Sprite
    {
        //Create the properties of the class

        protected Texture2D spriteTexture;
        protected Rectangle spritePosition;
        protected Color spriteColour;

        //constructor - needed for the creating instances of the class
        public Sprite(Texture2D intexture, Rectangle inposition, Color incolour)
        {
            spriteTexture = intexture;
            spritePosition = inposition;
            spriteColour = incolour;
        }

        public void DrawSprite(SpriteBatch inspriteBatch)
        {
            inspriteBatch.Draw(spriteTexture, spritePosition, spriteColour);
        }
        public Rectangle Position
        {
            set { spritePosition = value; }
            get { return spritePosition;  }
        }
        
        public Texture2D Texture
        {
            set { spriteTexture = value; }
            get { return spriteTexture;  }
        }
    }
}
    
