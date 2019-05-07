using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Source
{
	public class Paddle : GameObject
	{
		public Texture2D texture { get; set; }
        Vector2 position;
		SpriteBatch spriteBatch;
		Game game;
        public int vel { get; set; }

        private Rectangle boxCollision;

        public Paddle(Game game,SpriteBatch spriteBatch)
		{
			this.game = game;
			texture = game.Content.Load<Texture2D>("barraarkanoid");
			position = new Vector2(100, 300);
			this.spriteBatch = spriteBatch;
            vel = 5;
		}

		public void Input()
		{
			if(Keyboard.GetState().IsKeyDown(Keys.Left))
			{
				position.X-= vel;
			}
			else if(Keyboard.GetState().IsKeyDown(Keys.Right))
			{
				position.X+= vel;
			}
		}

		public void Draw()
		{
			spriteBatch.Begin();
			spriteBatch.Draw(texture, position, Color.White);
			spriteBatch.End();
            boxCollision = new Rectangle((int)position.X,
               (int)position.Y, texture.Width, texture.Height);

        }

        public Rectangle GetBoxCollison()
        {
            return boxCollision;
        }
    }
}
