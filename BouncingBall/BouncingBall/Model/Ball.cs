using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BouncingBall.Model
{
    class Ball
    {
        private float centerX;
        private float centerY;       
        private float diameter;       
        private float speedX;       
        private float speedY;       

        public Ball()
        {
            centerX = 0.5f;
            centerY = 0.5f;
            diameter = 0.1f;
            speedX = 0.3f;
            speedY = 0.4f;
        }

        public float CenterX
        {
            get { return centerX; }
            set { centerX = value; }
        }

        public float CenterY
        {
            get { return centerY; }
            set { centerY = value; }
        }

        public float Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public float SpeedX
        {
            get { return speedX; }
            set { speedX = value; }
        }

        public float SpeedY
        {
            get { return speedY; }
            set { speedY = value; }
        }

    }
}
