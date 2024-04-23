using UnityEngine;
using UnityEngine.Events;

public class TutorialManager: MonoBehaviour{
    public UnityEvent OnTutorialEnd;
    [SerializeField] private DialogueController dialogueController;
    [SerializeField] private TutorialDisplayUIController tutorialDisplayUIController;
    public void StartTutorial(){

    }


}