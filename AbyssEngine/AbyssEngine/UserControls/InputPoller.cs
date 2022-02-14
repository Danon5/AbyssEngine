namespace AbyssEngine.UserControls
{
    public class InputPoller
    {
        public void Poll()
        {
            KeyStateTracker.UpdateState();
            MouseStateTracker.UpdateState();
        }
    }
}