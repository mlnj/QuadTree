using Priority_Queue;

namespace QuadTree
{
    public class ItemNode<T> : FastPriorityQueueNode
    {
        public T Item;

        public ItemNode(T item)
        {
            Item = item;
        }
    }
}
