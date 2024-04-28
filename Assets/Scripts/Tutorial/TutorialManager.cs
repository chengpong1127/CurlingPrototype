using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;

public class TutorialManager : MonoBehaviour
{
    public UnityEvent OnTutorialEnd;
    [SerializeField] private AvatarWithDialogue tutor;
    [SerializeField] private RuleDisplayUIController tutorialDisplayUIController;
    private void Awake()
    {
    }
    public void StartTutorial()
    {
        tutorialDisplayUIController.OnTutorialEnd.AddListener(EndTutorial); // d
        tutorialDisplayUIController.StartTutorial();// d
    }

    private void EndTutorial()
    {
        Debug.Log("Tutorial Ended");
        OnTutorialEnd.Invoke();
    }

    public void ActivateTutorAnimationTrigger(string trigger){
        tutor.ActivateAnimation(trigger);
    }

}