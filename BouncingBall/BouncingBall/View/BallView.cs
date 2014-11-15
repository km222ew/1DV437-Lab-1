using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using BouncingBall.Model;

namespace BouncingBall.View
{
    class BallView
    {
        private Camera camera;

        private SpriteBatch spriteBatch;
        private Texture2D ballTexture;

        private Texture2D borderTexture;

        public BallView(GraphicsDevice graphicsDevice, Texture2D ball)
        {
            camera = new Camera();
            camera.setDimensions(graphicsDevice.Viewport.Width, graphicsDevice.Viewport.Height);

            borderTexture = new Texture2D(graphicsDevice, 1, 1, false, SurfaceFormat.Color);
            borderTexture.SetData(new[] { Color.White });

            spriteBatch = new SpriteBatch(graphicsDevice);
            ballTexture = ball;
        }

        public void DrawBall(float centerX, float centerY, float diameter)
        {
            int visualX = (int)(centerX * camera.Scale + Camera.BorderIndent);
            int visualY = (int)(centerY * camera.Scale + Camera.BorderIndent);
            int ballSize = (int)(diameter * camera.Scale);

            Rectangle ball = new Rectangle(visualX - ballSize / 2, visualY - ballSize / 2, ballSize, ballSize);

            spriteBatch.Begin();
            spriteBatch.Draw(ballTexture, ball, Color.White);
            spriteBatch.End();
        }

        public void DrawBorder()
        {
            Color color = Color.Pink;

            spriteBatch.Begin();
            //Top
            spriteBatch.Draw(borderTexture, new Rectangle(Camera.BorderIndent, Camera.BorderIndent, camera.WidthForBorder, camera.BorderThickness), color);
            //Left
            spriteBatch.Draw(borderTexture, new Rectangle(Camera.BorderIndent, Camera.BorderIndent, camera.BorderThickness, camera.HeigthForBorder), color);
            //Right
            spriteBatch.Draw(borderTexture, new Rectangle(Camera.BorderIndent + camera.WidthForBorder, Camera.BorderIndent, camera.BorderThickness, camera.HeigthForBorder), color);
            //Bottom
            spriteBatch.Draw(borderTexture, new Rectangle(Camera.BorderIndent, Camera.BorderIndent + camera.HeigthForBorder, camera.WidthForBorder, camera.BorderThickness), color);
            spriteBatch.End();
        }
    }
}
