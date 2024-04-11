using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonWithoutDestroy<GameManager>
{
    public void QuitGame(){
        Application.Quit();
    }
    public void EnterTutorial(){
        SceneManager.LoadScene("GameScene");
    }
    public void EnterPractice(){
        SceneManager.LoadScene("GameScene");
    }
}
