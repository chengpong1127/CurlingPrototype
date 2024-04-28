using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeGameController : MonoBehaviour
{
    private Vector3 initialCurlingStonePosition;
    private Vector3 initialCurlingBroomPosition;

    private Quaternion initialCurlingStoneRotation;
    private Quaternion initialCurlingBroomRotation;
    
    [SerializeField]
    private GameObject curlingStone;
    [SerializeField]
    private GameObject curlingBroom;

    public void Start()
    {   
        initialCurlingStonePosition = curlingStone.transform.position;
        initialCurlingBroomPosition = curlingBroom.transform.position;
        initialCurlingBroomRotation = curlingBroom.transform.rotation;
        initialCurlingStoneRotation = curlingStone.transform.rotation;
        Debug.LogWarning("Initial curling stone position: " + initialCurlingStonePosition);
        Debug.LogWarning("Initial curling broom position: " + initialCurlingBroomPosition);
    }

    // Update is called once per frame
    public void RestartPracticeGame()
    {
        Debug.LogWarning("Restarting practice game");
        // Reset the position, velocity, rotation of the stone and broom
        curlingStone.transform.position = initialCurlingStonePosition;
        curlingStone.transform.rotation = initialCurlingStoneRotation;
        curlingStone.GetComponent<Rigidbody>().velocity = Vector3.zero;
        curlingStone.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        curlingBroom.transform.position = initialCurlingBroomPosition;
        curlingBroom.transform.rotation = initialCurlingBroomRotation;
        curlingBroom.GetComponent<Rigidbody>().velocity = Vector3.zero;
        curlingBroom.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }

    public void Update()
    {
        
    }
}