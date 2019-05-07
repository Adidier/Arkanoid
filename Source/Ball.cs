using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Source
{
    public class Ball :  GameObject
    {
        private Rectangle boxCollision;
        private Texture2D texture;
        private Vector2 position;
        private Vector2 direction;
        SpriteBatch spriteBatch;
        Game game;

        public Ball(Game game, SpriteBatch spriteBatch)
        {
            this.game = game;
            texture = game.Content.Load<Texture2D>("bolaarkanoid");
            position = new Vector2(100, 300);
            

            this.spriteBatch = spriteBatch;
            direction = new Vector2(0, 1);
        }

        public void Init(Vector2 pos)
        {
            this.position = pos;
        }

        public void CheckCollision(Paddle paddle,Wall wall)
        {
            if(boxCollision.Intersects(paddle.GetBoxCollison()))
            {
                direction.Y = direction.Y* -1;
                

            }

            foreach(var brick in wall.Bricks)
            {
                if (boxCollision.Intersects(brick.GetBoxCollison()))
                {
                    direction.Y = direction.Y * -1;
                    wall.Bricks.Remove(brick);
                    break;
                }
            }
            
        }

        public void Update()
        {
            this.position.X = this.position.X + direction.X;
            this.position.Y += direction.Y;

            boxCollision = new Rectangle((int)position.X, 
                (int)position.Y, texture.Width, texture.Height);
        }

        public Rectangle GetBoxCollision()
        {
            return boxCollision;
        }
        
        public void Draw()
        {
            spriteBatch.Begin();
            spriteBatch.Draw(texture, position, Color.White);
            spriteBatch.End();
        }

        public void Input()
        {
            
        }
    }
}
