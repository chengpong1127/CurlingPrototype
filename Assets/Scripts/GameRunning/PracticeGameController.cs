using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR.LegacyInputHelpers;
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
    [SerializeField]
    private GameObject originalCamera;
    [SerializeField]
    private GameObject sweepingCamera;
    [SerializeField]
    private float followingCameraOffset = 0.5f;

    private float hogLinePosition;
    private bool switchedView = false;
    private Vector3 playerYPosition;

    public void Start()
    {   
        initialCurlingStonePosition = curlingStone.transform.position;
        initialCurlingBroomPosition = curlingBroom.transform.position;
        initialCurlingBroomRotation = curlingBroom.transform.rotation;
        initialCurlingStoneRotation = curlingStone.transform.rotation;
        hogLinePosition = GameObject.Find("HogLine1").transform.position.z;
        Debug.LogWarning("Initial curling stone position: " + initialCurlingStonePosition);
        Debug.LogWarning("Initial curling broom position: " + initialCurlingBroomPosition);
    }

    public void Update()
    {
        // if (curlingStone.transform.position.z > hogLinePosition && !switchedView)
        // {
        //     SwitchView();
        // }
        // if (switchedView)
        // {
        //     FollowingCurlingStone();
        // }
    }

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
        // switchedView = false;
        // originalCamera.gameObject.SetActive(true);
        // sweepingCamera.gameObject.SetActive(false); 
    }

    private void SwitchView()
    {
        Debug.LogWarning("Switching View");
        playerYPosition = originalCamera.transform.position;
        originalCamera.gameObject.SetActive(false);
        sweepingCamera.gameObject.SetActive(true);
        switchedView = true;
    }

    private void FollowingCurlingStone()
    {
        Vector3 stonePosition = curlingStone.transform.position;
        Vector3 cameraOffset = -curlingStone.transform.right * followingCameraOffset + curlingStone.transform.forward * followingCameraOffset;
        sweepingCamera.transform.position = stonePosition + cameraOffset;
        sweepingCamera.transform.position = new Vector3(sweepingCamera.transform.position.x, playerYPosition.y, sweepingCamera.transform.position.z);
    }
}