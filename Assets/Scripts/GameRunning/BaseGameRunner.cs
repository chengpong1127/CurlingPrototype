using System;

public abstract class BaseGameRunner : Singleton
{
    public abstract void StartGame();
    public event Action OnGameEnd = delegate { };
}
