using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is used to control the avatar. The class will be attached to the avatar object.
/// </summary>
public class AvatarController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void ActivateAnimation(string trigger){
        animator.SetTrigger(trigger);
    }
}
