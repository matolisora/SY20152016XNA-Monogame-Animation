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
    public class Player
    {
        #region Properties

        Vector2 playerPosition;
        Texture2D playerTexture;
        ContentManager content;
        Animation runAnimation;
        AnimationPlayer animationPlayer;

        #endregion

        public Player(ContentManager content)
        {
            this.content = content;
            playerPosition = new Vector2(0, 0);
        }

        public void LoadContent()
        {
            playerTexture = content.Load<Texture2D>("Run");
            runAnimation = new Animation(playerTexture, 0.1f, true, 8);
            animationPlayer.PlayAnimation(runAnimation);
        }

        public void Update(GameTime gametime)
        {
        
        }

        public void Draw (GameTime gameTime, SpriteBatch spriteBatch)
        {
            animationPlayer.Draw(gameTime,
                spriteBatch, playerPosition,
                SpriteEffects.FlipHorizontally);
        }

    }
}
