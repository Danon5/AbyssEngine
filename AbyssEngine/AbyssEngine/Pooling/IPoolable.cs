namespace AbyssEngine.Pooling
{
    public interface IPoolable
    {
        void OnEnterPool();
        void OnExitPool();
    }
}