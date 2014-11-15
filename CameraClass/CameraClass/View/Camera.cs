using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace CameraClass.View
{
    class Camera
    {
        private int sizeOfTile = 64;
        private int borderSize = 64;
        private float scale;
        private int boardWidth = 8;
        private int boardHeight = 8;

        
        //Uppgift 1. Kod
        public Vector2 GetWhiteVisualPosition(Vector2 logicalPosition)
        {
            float visualX = borderSize + logicalPosition.X * sizeOfTile;
            float visualY = borderSize + logicalPosition.Y * sizeOfTile;

            return new Vector2(visualX, visualY);
        }

        //Uppgift 2. Rotation
        public Vector2 GetBlackVisualPosition(Vector2 logicalPosition)
        {
            float visualX = borderSize + (7 - logicalPosition.X ) * sizeOfTile;
            float visualY = borderSize + (7 - logicalPosition.Y) * sizeOfTile;

            return new Vector2(visualX, visualY);
        }

        //Uppgift 3. Skalning
        public void DoScaling(int width, int heigth)
        {
            int scaleX = (width - borderSize * 2) / boardWidth;
            int scaleY = (heigth - borderSize * 2) / boardHeight;

            scale = scaleX;

            if (scaleY < scaleX)
            {
                scale = scaleY;
            }
        }
    }
}
