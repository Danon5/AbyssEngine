namespace AbyssEngine.Pooling
{
    public sealed class ObjectPool<T> where T : IPoolable
    {
        public T PooledInstantiate()
        {
            return default;
        }
    }
}