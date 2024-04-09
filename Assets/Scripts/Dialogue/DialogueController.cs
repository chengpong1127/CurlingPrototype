using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueController: MonoBehaviour{
    public UnityEvent OnDialogueStart;
    public UnityEvent OnNextParagraph;
    public UnityEvent OnDialogueEnd;

    public Message[] Messages;
    private Queue<Message> running_messages;

    public Message CurrentParagraph{
        get{
            if (running_messages == null || running_messages.Count == 0){
                return null;
            }else{
                return running_messages.Peek();
            }
        }
    }
    [ContextMenu("StartDialogue")]
    public void StartDialogue(){
        OnDialogueStart.Invoke();
        running_messages = new Queue<Message>(Messages);
    }
    [ContextMenu("NextParagraph")]
    public void NextParagraph(){
        if (running_messages.Count == 0){
            EndDialogue();
            return;
        }
        running_messages.Dequeue();
        OnNextParagraph.Invoke();
    }
    [ContextMenu("EndDialogue")]
    public void EndDialogue(){
        OnDialogueEnd.Invoke();
        running_messages = null;
    }


}