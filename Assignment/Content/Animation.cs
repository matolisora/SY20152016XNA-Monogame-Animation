using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace SpriteAnimation
{
    class Animation
    {
        public Texture2D texture;

        public float frameTime;
        public bool istooping;
        public int FrameCount;

        public int FrameWidth
        {
            get { return texture.Width / FrameCount; }
        }

        public int FrameHeight
        {
            get { return texture.Height; }
        }

        public Animation(
            Texture2D texture,
            float frameTime,
            bool istooping,
            int FrameCount)
        {
            this.texture = texture;
            this.frameTime = frameTime;
            this.istooping = istooping;
            this.FrameCount = FrameCount;
        }
    }
}
