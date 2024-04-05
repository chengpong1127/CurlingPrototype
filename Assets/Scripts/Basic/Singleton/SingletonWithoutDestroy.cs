using UnityEngine;

[DisallowMultipleComponent]
public class SingletonWithoutDestroy : Singleton
{
    protected override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(gameObject);
    }
}