using UnityEngine;

public class AvatarWithDialogue : AvatarController
{
    [SerializeField] private MessageList messageList;
    [SerializeField] private DialogueUIController dialogueUIController;

    private int messageIndex = 0;

    [ContextMenu("StartDialogue")]
    public void StartDialogue()
    {
        messageIndex = 0;
        EnterMessage(messageList.messages[messageIndex]);
    }

    public void NextMessage()
    {
        messageIndex++;
        if (messageIndex < messageList.messages.Count)
        {
            EnterMessage(messageList.messages[messageIndex]);
        }
        else
        {
            dialogueUIController.HideDialogue();
        }
        var message = messageList.messages[messageIndex];
        var EventName = message.GameEventTrigger;
        GameEvent.RunEvent(EventName);
    }

    private void EnterMessage(MessageWithGameEventTrigger message)
    {
        dialogueUIController.ShowDialogue(message);
       
    }

}