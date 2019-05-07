using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Source
{
    public class Wall 
    {
        SpriteBatch spriteBatch;
        Game game;

        public List<Brick> Bricks { get; set; }
        int lineSize;
        int numberLines;       

        public Wall(Game game, SpriteBatch spriteBatch)
        {
            this.game = game;
            this.spriteBatch = spriteBatch;
            Bricks = new List<Brick>();
        }

        public void Init(int lineSize,int numberLines)
        {
            this.lineSize = lineSize;
            this.numberLines = numberLines;
            int count = lineSize * numberLines;
            int x = 0;
            int y = 0;
            for (int i=1;i<=count;i++)
            {
                var brick = new Brick(game, spriteBatch);
                brick.Init(new Vector2(x, y));
                if (i <= 6)
                {
                    brick.color = Color.Aqua;
                }
                else if(i<=12)
                {
                    brick.color = Color.Red;
                }
                else if (i <= 18)
                {
                    brick.color = Color.Purple;
                }
                else
                {
                    brick.color = Color.Pink;
                }
                Bricks.Add(brick);

                x += 60;
                if (i % 6 == 0)
                {
                   x = 0;
                   y += 25;
                }
                
            }

        }

        public void Draw()
        {
            foreach(var brick in Bricks)
            {
                brick.Update();
                brick.Draw();
            }
        }
    }
}
