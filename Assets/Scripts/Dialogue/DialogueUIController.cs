using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class DialogueUIController : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private GameObject dialoguePanel;

    public void ShowDialogue(MessageWithGameEventTrigger message)
    {
        dialoguePanel.SetActive(true);
        dialogueText.text = message.message;
    }

    public void HideDialogue()
    {
        dialoguePanel.SetActive(false);
    }
}