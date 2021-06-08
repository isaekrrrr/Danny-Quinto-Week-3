using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTrigger : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;

    public int DoorStart = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myDoor.Play("DoorOpen", 0, 0);
            }
        }
    }

}
