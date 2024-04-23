using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;

public class TutorialManager: MonoBehaviour{
    public UnityEvent OnTutorialEnd;
    [SerializeField] private AvatarWithDialogue avatar;
    [SerializeField] private TutorialDisplayUIController tutorialDisplayUIController;
    private void Awake(){
    }
    public void StartTutorial(){
        //tutorialDisplayUIController.OnTutorialEnd.AddListener(EndTutorial);
    }

    private void EndTutorial(){
        //Debug.Log("Tutorial Ended");
    }

}