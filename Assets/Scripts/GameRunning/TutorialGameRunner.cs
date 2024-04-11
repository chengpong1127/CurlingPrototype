using UnityEngine;

public class TutorialGameRunner : BaseGameRunner<TutorialGameRunner>
{
    [SerializeField] private GameObject m_tutorialElements;
    public override void StartGame()
    {
        m_tutorialElements.SetActive(true);
    }
}