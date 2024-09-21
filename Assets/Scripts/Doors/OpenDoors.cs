using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour, IInteractable
{

    [SerializeField]
    private Animator _doorAnim;


    public void Interact()
    {
        Debug.Log("Opening Door");
        _doorAnim.SetBool("OpenClose", !_doorAnim.GetBool("OpenClose"));
    }
}
