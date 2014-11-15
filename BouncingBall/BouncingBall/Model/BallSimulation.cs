using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace BouncingBall.Model
{
    class BallSimulation
    {
        private Ball ball;

        public BallSimulation()
        { 
            ball = new Ball();
        }

        public void Update(GameTime gameTime)
        {
            float timeElapsedInSeconds = (float)gameTime.ElapsedGameTime.TotalSeconds;

            ball.CenterX += ball.SpeedX * timeElapsedInSeconds;

            if (ball.CenterX + ball.Diameter / 2 > 1.0f || ball.CenterX - ball.Diameter / 2 < 0.0f)
            {
                ball.SpeedX = ball.SpeedX * -1.0f;
            }

            ball.CenterY += ball.SpeedY * timeElapsedInSeconds;

            if (ball.CenterY + ball.Diameter / 2 > 1.0f || ball.CenterY - ball.Diameter / 2 < 0.0f)
            {
                ball.SpeedY = ball.SpeedY * -1.0f;
            }
        }

        public float GetBallCenterX()
        {
            return ball.CenterX;
        }

        public float GetBallCenterY()
        {
            return ball.CenterY;
        }

        public float GetBallDiameter()
        {
            return ball.Diameter;
        }
    }
}
