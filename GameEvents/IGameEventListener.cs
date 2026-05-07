
public interface IGameEventListener
{

    void OnEventRaised();
    void OnEventRaised<T>(T arg);
    // void OnEventRaised<T1, T2>(T1 arg, T2 arg2);
}