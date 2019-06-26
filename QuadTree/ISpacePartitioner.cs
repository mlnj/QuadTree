using System.Collections.Generic;
using Priority_Queue;
using SFML.Graphics;
using SFML.System;

namespace QuadTree
{
    public interface ISpacePartitioner<T>
    {
        int Count { get; }

        void Update();
        void Add(T t);
        void Remove(T t);

        T GetClosestObject(Vector2f pos, float maxDistance = float.MaxValue);

        T[] GetKClosestObjects(Vector2f pos, uint k, float range = float.MaxValue);
        T[] GetObjectsInRange(Vector2f pos, float range = float.MaxValue);
        T[] GetObjectsInRect(FloatRect rect);

        void GetKClosestObjects(Vector2f pos, uint k, float range, FastPriorityQueue<ItemNode<T>> results);
        void GetObjectsInRange(Vector2f pos, float range, IList<T> results);
        void GetObjectsInRect(FloatRect rect, IList<T> results);
    }
}
