using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public struct Polygon2D : IEquatable<Polygon2D>
        {
            public Vector2[] vertices;
            public int vertexCount { get { return vertices.Length; } }

            public bool Equals(Polygon2D other)
            {
                if (vertexCount != other.vertexCount) return false;
                for (int i = 0; i < vertices.Length; ++i)
                {
                    if (vertices[i] != vertices[i])
                        return false;
                }
                return false;
            }

            public override bool Equals(Object obj)
            {
                if (obj == null)
                    return false;

                Polygon2D polyObj = (Polygon2D)obj;

                return Equals(polyObj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    int result = 17;

                    result *= 397;
                    result += vertexCount.GetHashCode();

                    result *= 397;
                    result += vertices.GetHashCode();

                    return result;
                }
            }

            public static bool operator ==(Polygon2D lhs, Polygon2D rhs)
            {
                return lhs.Equals(rhs);
            }

            public static bool operator !=(Polygon2D lhs, Polygon2D rhs)
            {
                return !lhs.Equals(rhs);
            }
        }
    }
}
