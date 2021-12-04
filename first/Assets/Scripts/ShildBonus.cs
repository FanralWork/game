using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;



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
            StartCoroutine(TimerCanJump());
        }

        
    }

    private IEnumerator TimerCanJump()
    {
        yield return new WaitForSeconds(5f);
        movement.CanJump = false;
    }
}