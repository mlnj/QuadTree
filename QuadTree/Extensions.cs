using System;
using SFML.Graphics;
using SFML.System;

namespace QuadTree
{
    public static class Extensions
    {
        public static Vector2f Normalized(this Vector2f v)
        {
            float l = v.Length();
            if (l == 0f)
                return new Vector2f(0,0);
            return v / l;
        }

        public static float Length(this Vector2f v)
        {
            return (float) Math.Sqrt((v.X * v.X) + (v.Y * v.Y));
        }

        public static float SquaredLength(this Vector2f v)
        {
            return (v.X * v.X) + (v.Y * v.Y);
        }

        public static float SquaredDistance(this FloatRect f, Vector2f v)
        {
            var max = f.Max();

            var dx1 = v.X - max.X;
            if (dx1 < 0) dx1 = 0f;
            var dx = f.Left - v.X;
            if (dx1 > dx) dx = dx1;

            var dy1 = v.Y - max.Y;
            if (dy1 < 0) dy1 = 0f;
            var dy = f.Top - v.Y;
            if (dy1 > dy) dy = dy1;

            return (dx * dx) + (dy * dy);
        }

        public static Vector2f Max(this FloatRect f)
        {
            return new Vector2f(f.Left + f.Width, f.Top + f.Height);
        }

        public static Vector2f Min(this FloatRect f)
        {
            return new Vector2f(f.Left, f.Top);
        }

        public static Vector2f Dimensions(this FloatRect f)
        {
            return new Vector2f(f.Width, f.Height);
        }

        public static Vector2f Center(this FloatRect f)
        {
            return new Vector2f(f.Left + (f.Width / 2f), f.Top + (f.Height / 2f));
        }
    }
}
