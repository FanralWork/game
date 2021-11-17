using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShildBonus : MonoBehaviour
{
    public Colider bc; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "shildCoin")
        {
            Destroy(other.gameObject);
            

        }

    }
}