using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowBonus : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "slowBonus")
        {
            Destroy(other.gameObject);
            if (movement.forwardForce > movement.MinforwardSpeed)
            {
                movement.forwardForce -= 100;
            }

            if (movement.sidewayForce > movement.MinsidewaySpeed)
            {
                movement.sidewayForce -= 10;
            }

        }

    }
}
