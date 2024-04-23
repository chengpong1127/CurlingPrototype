using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class MessageList : ScriptableObject
{
    public List<MessageWithAnimationTrigger> messages = new();
}
