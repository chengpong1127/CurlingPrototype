using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneManager : MonoBehaviour
{
    [ContextMenu("EnterTutorial")]
    public void EnterTutorial()
    {
        GameManager.Instance.EnterTutorial();
    }
    [ContextMenu("EnterPractice")]
    public void EnterPractice(){
        GameManager.Instance.EnterPractice();
    }
    [ContextMenu("EnterTactic")]
    public void EnterTactic(){

    }
    [ContextMenu("QuitGame")]
    public void QuitGame(){
        GameManager.Instance.QuitGame();
    }
    [ContextMenu("EnterSetting")]
    public void EnterSetting(){
        
    }
}
