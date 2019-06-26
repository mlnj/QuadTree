using System.Collections.Generic;
using SFML.Graphics;

namespace QuadTree
{
    public static class QuadTreeVisualization
    {
        public static void DrawRegions<T>(QuadTree<T> tree, RenderTarget target, RenderStates states, Color color)
            where T : Transformable
        {
            var regions = new List<FloatRect>();
            tree.GetAllRegions(regions);

            var c = color;
            var shape = new RectangleShape
            {
                FillColor = Color.Transparent,
                OutlineThickness = 1f,
                OutlineColor = c
            };

            foreach (var fr in regions)
            {
                shape.Size = fr.Dimensions();
                shape.Position = fr.Min();
                target.Draw(shape, states);
            }
        }
    }
}
