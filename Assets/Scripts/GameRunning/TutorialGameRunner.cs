using UnityEngine;

public class TutorialGameRunner : BaseGameRunner<TutorialGameRunner>
{
    [SerializeField] private GameObject m_tutorialElements;
    [SerializeField] public TutorialManager TutorialManager;
    public override async void StartGame()
    {
        m_tutorialElements.SetActive(true);

    }
}