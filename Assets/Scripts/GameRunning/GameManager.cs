using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public class GameManager : SingletonWithoutDestroy<GameManager>
{
    private TutorialGameRunner tutorialGameRunner;
    private PracticeGameRunner practiceGameRunner;

    public void QuitGame()
    {
        Application.Quit();
    }

    public async void EnterTutorial()
    {
        await SceneManager.LoadSceneAsync("GameScene");
        tutorialGameRunner = TutorialGameRunner.Instance;
        tutorialGameRunner.OnRequestExit += requestExitHandler;
        tutorialGameRunner.StartGame();
    }

    public async void EnterPractice()
    {
        await SceneManager.LoadSceneAsync("GameScene");
        practiceGameRunner = PracticeGameRunner.Instance;
        practiceGameRunner.OnRequestExit += requestExitHandler;
        practiceGameRunner.StartGame();
    }

    private void requestExitHandler()
    {
        if (tutorialGameRunner != null)
        {
            tutorialGameRunner.OnRequestExit -= requestExitHandler;
        }
        if (practiceGameRunner != null)
        {
            practiceGameRunner.OnRequestExit -= requestExitHandler;
        }
        SceneManager.LoadScene("StartScene");
    }
}
