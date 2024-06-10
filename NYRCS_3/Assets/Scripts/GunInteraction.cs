using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunInteraction : MonoBehaviour
{
    private bool isBeingHeld = false;
    public GameObject playerhand;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerHand)
        {
            isBeingHeld = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject == playerhand)
        {
            isBeingHeld = false;
        }
    }
    public bool IsBeingHeld()
    {
        return isBeingHeld;
    }
}
