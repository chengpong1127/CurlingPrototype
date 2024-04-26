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
    }

    private void EnterMessage(MessageWithAnimationTrigger message)
    {
        dialogueUIController.ShowDialogue(message);
        if (message.animationTrigger != "")
        {
            ActivateAnimation(message.animationTrigger);
        }
    }

}