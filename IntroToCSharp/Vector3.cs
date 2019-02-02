﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    struct Vector3
    {
        float x, y, z;
        public Vector3(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        
        public Vector3 Sum(Vector3 rhs)
        {
            return new Vector3(x + rhs.x, y + rhs.y, z + rhs.z);
        }
        public Vector3 Difference(Vector3 rhs)
        {
            return new Vector3(x - rhs.x, y - rhs.y, z - rhs.z);
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
        public Vector3 Normalized()
        {
            return new Vector3(x / Magnitude(), y / Magnitude(), z / Magnitude());
        }
        public float DotProduct(Vector3 rhs)
        {
            return x * rhs.x + y * rhs.y + z + rhs.z;
        }
    }
}
