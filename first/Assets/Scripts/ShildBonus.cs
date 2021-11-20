using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShildBonus : MonoBehaviour
{
    public Collider bc;
    public Transform player;
    public PlayerMovement movement;

    private void OnTriggerEnter(Collider other)
    {

        bc.enabled = true;
        if (other.gameObject.tag == "shildCoin")
        {
            Destroy(other.gameObject);
            movement.CanJump = true;
        }
    }
}