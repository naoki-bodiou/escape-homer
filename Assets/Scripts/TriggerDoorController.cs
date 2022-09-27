using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{

    public Animator myDoor = null;

    public bool openTrigger = false;
    public bool closeTrigger = false;

    public string doorOpen = "DoorOpen";
    public string doorClose = "DoorClose";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (openTrigger)
            {
                myDoor.Play("DoorOpen", 0, 0.0f);
                //gameObject.setActive(false);
            }
            else if (closeTrigger)
            {
                myDoor.Play("DoorClose", 0, 0.0f);
                //gameObject.setActive(false);
            }
        }
    }
}