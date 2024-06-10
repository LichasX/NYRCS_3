using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{

    private bool isBeingHeld = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            isBeingHeld = true;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            isBeingHeld = false;
        }

    }
    public bool IsBeingHeld()
    {
        return isBeingHeld;
    }
   
}
