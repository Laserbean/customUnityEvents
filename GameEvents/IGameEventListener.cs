


namespace Laserbean.CustomUnityEvents
{
    public interface IGameEventListener
    {
        void OnEventRaised();
        void OnEventRaised<T>(T arg);
    }
}