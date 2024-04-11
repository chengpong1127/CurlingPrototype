using System;

public abstract class BaseGameRunner<T> : Singleton<T> where T : BaseGameRunner<T>
{
    public abstract void StartGame();
    public event Action OnGameEnd = delegate { };
}
