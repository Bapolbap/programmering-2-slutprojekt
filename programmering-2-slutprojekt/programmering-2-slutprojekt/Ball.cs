using System;
using System.Collections.Generic;
using System.Text;

namespace programmering_2_slutprojekt
{
    public class Ball
    {
        float xPosition;
        float yPosition;
        float xVelocity;
        float yVelocity;
        float xAcceleration;
        float yAcceleration;
        float radius;
        int id;

        public Ball(float xp, float yp, float xv, float yv, float xa, float ya, float r, int i)
        {
            this.xPosition = xp;
            this.yPosition = yp;
            this.xVelocity = xv;
            this.xVelocity = yv;
            this.xAcceleration = xa;
            this.yAcceleration = ya;
            this.radius = r;
            this.id = i;
        }
    }
}
