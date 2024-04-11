using UnityEngine;

[DisallowMultipleComponent]
public class SingletonWithoutDestroy<T> : Singleton<T> where T : MonoBehaviour
{
    protected override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(gameObject);
    }
}