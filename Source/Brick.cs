using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Source
{
    class Brick : GameObject
    {
        private Texture2D texture;
        private Vector2 position;
        SpriteBatch spriteBatch;
        Game game;
        public Color color { get; set; }

        public Brick(Game game, SpriteBatch spriteBatch)
        {
            this.game = game;
            Init(new Vector2(0,0));
            this.spriteBatch = spriteBatch;
        }

        public void Init(Vector2 position)
        {
            texture = game.Content.Load<Texture2D>("brick");
            this.position = position;
        }

        public void Update(Vector2 ballPosition)
        {

        }

        public void Draw()
        {
            spriteBatch.Begin();
            spriteBatch.Draw(texture, position, color);
            spriteBatch.End();
        }

        public void Input()
        {
        }
    }
}
