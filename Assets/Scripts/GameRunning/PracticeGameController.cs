using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeGameController : MonoBehaviour
{
    private Vector3 initialPlayerPosition;
    private Vector3 initialCurlingStonePosition;
    private Vector3 initialCurlingBroomPosition;

    public void Start()
    {
        initialCurlingStonePosition = GameObject.Find("Curling Stone").transform.position;
        initialCurlingBroomPosition = GameObject.Find("Curling Broom").transform.position;     
        Debug.LogWarning("Initial curling stone position: " + initialCurlingStonePosition);
        Debug.LogWarning("Initial curling broom position: " + initialCurlingBroomPosition);
    }

    // Update is called once per frame
    public void RestartPracticeGame()
    {
        Debug.LogWarning("Restarting practice game");
        GameObject.Find("Curling Stone").transform.position = initialCurlingStonePosition;
        GameObject.Find("Curling Broom").transform.position = initialCurlingBroomPosition;
    }
}