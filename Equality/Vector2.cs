using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality
{
    struct Vector2 : IEquatable<Vector2>
    {
        float x, y;

        public Vector2(float _x, float _y)
        {
            x = _x;
            y = _y;
        }

        public Vector2 Sum(Vector2 rhs)
        {
            return new Vector2(x + rhs.x, y + rhs.y);
        }
        public Vector2 Difference(Vector2 rhs)
        {
            return new Vector2(x - rhs.x, y - rhs.y);
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y);
        }
        public Vector2 Normalized()
        {
            return new Vector2(x / Magnitude(), y / Magnitude());
        }
        public float DotProduct(Vector2 rhs)
        {
            return x * rhs.x + y * rhs.y;
        }

        bool calculateDifference(float a, float b, float maxRelDiff)
        {
            float diff = Math.Abs(a - b);
            a = Math.Abs(a);
            b = Math.Abs(b);

            float largest = (b < a) ? b : a;

            if (diff <= largest * maxRelDiff)
                return true;
            return false;
        }

        public bool Equals(Vector2 other)
        {
            return calculateDifference(x, other.x, float.Epsilon) &&
                calculateDifference(y, other.y, float.Epsilon);
        }

        public override bool Equals(object obj)
        {
            Vector2 vecObj = (Vector2)obj;
            return Equals(vecObj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;

                result *= 397;
                result += x.GetHashCode();

                result *= 397;
                result += y.GetHashCode();

                return result;
            }
        }

        public static bool operator == (Vector2 lhs, Vector2 rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            return !lhs.Equals(rhs);
        }
    }
}
