using UnityEngine;

[System.Serializable]
public class Message
{
    public string title;
    public Sprite image;
    [TextArea(3, 10)]
    public string message;
}