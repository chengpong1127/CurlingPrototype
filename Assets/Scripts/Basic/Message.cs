using UnityEngine;

[CreateAssetMenu(fileName = "New Message", menuName = "Message")]
public class Message : ScriptableObject
{
    public string title;
    public Sprite image;
    [TextArea(3, 10)]
    public string message;

}