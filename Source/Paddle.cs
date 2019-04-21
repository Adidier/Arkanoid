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
		private Texture2D texture;
		private Vector2 position;
		SpriteBatch spriteBatch;
		Game game;

		public Paddle(Game game,SpriteBatch spriteBatch)
		{
			this.game = game;
			texture = game.Content.Load<Texture2D>("barraarkanoid");
			position = new Vector2(0, 0);
			this.spriteBatch = spriteBatch;
		}

		public void Input()
		{
			if(Keyboard.GetState().IsKeyDown(Keys.Left))
			{
				position.X--;
			}
			else if(Keyboard.GetState().IsKeyDown(Keys.Right))
			{
				position.X++;
			}
		}

		public void Draw()
		{
			spriteBatch.Begin();
			spriteBatch.Draw(texture, position, Color.White);
			spriteBatch.End();
		}
	}
}
