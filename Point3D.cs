using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPoint2DAndClassPoint3D
{
    class Point3D : Point2D
    {
        private float z = 0.0f;

        public Point3D()
        {

        }

        public Point3D(float x,float y, float z): base(x, y)
        {
            this.z = z;
        }
        public float GetZ()
        {
            return z;
        }

        public void SetZ(float z)
        {
            this.z = z;
        }

        public float[] GetXYZ()
        {
            float[] xyz = new float[3] {x, y, z};
            return xyz;
        }

        public void SetXYZ(float x, float y, float z)
        {
            base.x = x;
            base.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return $"x = {x}, y = {y}, z = {z}";
        }
    }
}
