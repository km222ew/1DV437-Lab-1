using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace BouncingBall.View
{
    class Camera
    {
        private float scale;

        //Variables for border
        private static int borderIndent = 10;
        private int widthForBorder;       
        private int heigthForBorder;
        private int borderThickness = 1;
      
        public Camera() { }

        public void setDimensions(int width, int heigth)
        {
            int scaleX = (width - borderIndent * 2);
            int scaleY = (heigth - borderIndent * 2);

            setBorderVariables(width, heigth);           

            scale = scaleX;
            if (scaleY < scaleX)
            {
                scale = scaleY;
            }
        }

        private void setBorderVariables(int width, int heigth)
        {
            //Since the size is 1x1 keep the border same size in case the resolution isn't a square
            if (width > heigth)
            {
                width = heigth;
            }
            if (heigth > width)
            {
                heigth = width;
            }

            widthForBorder = width - borderIndent * 2;
            heigthForBorder = heigth - borderIndent * 2;
        }

        public float Scale
        {
            get { return scale; }
        }

        public static int BorderIndent
        {
            get { return Camera.borderIndent; }
        }

        public int WidthForBorder
        {
            get { return widthForBorder; }
        }

        public int HeigthForBorder
        {
            get { return heigthForBorder; }
        }

        public int BorderThickness
        {
            get { return borderThickness; }
        }
    }
}
