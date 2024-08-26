namespace SquareDino.TestTask.ObjectPool
{
    public interface IPooledObject
    {
        bool IsFree();

        void ReturnToPool();

        void Take();
    }
}