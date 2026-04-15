/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 06:52:12
 * Version: 1.0.173
 */

namespace FlAdmin.Common.Containers;

// reffed from https://stackoverflow.com/questions/5852863/fixed-size-queue-which-automatically-dequeues-old-values-upon-new-enqueues

public class FixedSizeQueue<T>(int size)
{
    public readonly Queue<T> queue = new();

    private int Size { get; } = size;

    public void Enqueue(T obj)
    {
        queue.Enqueue(obj);

        while (queue.Count > Size)
        {
            T outObj;
            queue.TryDequeue(out outObj);
        }
    }
}