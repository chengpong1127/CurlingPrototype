using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueController: MonoBehaviour{
    public UnityEvent OnDialogueStart;
    public UnityEvent OnNextParagraph;
    public UnityEvent OnDialogueEnd;

    public Dialogue dialogue;
    private Queue<string> running_paragraphs;

    public string CurrentParagraph{
        get{
            if (running_paragraphs == null || running_paragraphs.Count == 0){
                return null;
            }else{
                return running_paragraphs.Peek();
            }
        }
    }
    [ContextMenu("StartDialogue")]
    public void StartDialogue(){
        OnDialogueStart.Invoke();
        running_paragraphs = new Queue<string>();
        foreach (string paragraph in dialogue.paragraphs){
            running_paragraphs.Enqueue(paragraph);
        }
    }
    [ContextMenu("NextParagraph")]
    public void NextParagraph(){
        if (running_paragraphs.Count == 0){
            EndDialogue();
            return;
        }
        running_paragraphs.Dequeue();
        OnNextParagraph.Invoke();
    }
    [ContextMenu("EndDialogue")]
    public void EndDialogue(){
        OnDialogueEnd.Invoke();
        running_paragraphs = null;
    }


}