﻿using System;

namespace GetNeighbors
{
    /// <summary>
    /// Represents a point on the coordinate plane.
    /// </summary>
    public readonly struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}