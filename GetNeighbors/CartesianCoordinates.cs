using System;
using System.Collections.Generic;

namespace GetNeighbors
{
    public static class CartesianCoordinates
    {
        /// <summary>
        /// Gets from a set of points only points that are h-neighbors for a point with integer coordinates x and y.
        /// </summary>
        /// <param name="point">Given point with integer coordinates x and y.</param>
        /// <param name="h">Distance around a given point.</param>
        /// <param name="points">A given set of points.</param>
        /// <returns>Only points that are h-neighbors for a point with integer coordinates x and y.</returns>
        /// <exception cref="ArgumentNullException">Throw when array points is null.</exception>
        /// <exception cref="ArgumentException">Throw when h-distance is less or equals zero.</exception>
        public static Point[] GetNeighbors(Point point, int h, params Point[] points)
        {
            if (points is null)
            {
                throw new ArgumentNullException($"Throw when array points is null. {nameof(points)}");
            }

            if (h <= 0)
            {
                throw new ArgumentException("Throw when h-distance is less or equals zero.");
            }

            List<Point> result = new List<Point>();
            int count = points.Length;
            for (int i = 0; i < count; i++)
            {
                int x = points[i].X - point.X;
                int y = points[i].Y - point.Y;
                if (Math.Abs(x) <= h && Math.Abs(y) <= h)
                {
                    result.Add(points[i]);
                }
            }

            return result.ToArray();
        }
    }
}
