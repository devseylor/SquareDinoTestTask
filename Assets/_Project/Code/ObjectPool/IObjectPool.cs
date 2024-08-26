namespace SquareDino.TestTask.ObjectPool
{
    public interface IObjectPool<out T> where T : IPooledObject
    {
        T GetObject();
    }
}