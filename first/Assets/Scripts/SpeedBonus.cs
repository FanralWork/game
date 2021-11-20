using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : MonoBehaviour
{
    public PlayerMovement movement;
    public FollowPlayer fp;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "speedBonus")
        {
            Destroy(other.gameObject);
            fp.offset = fp.offset - new Vector3(0, 0, 5);
            if (movement.forwardForce < movement.MaxforwardSpeed)
            {
                movement.forwardForce += 100;
            }

            if (movement.sidewayForce < movement.MaxsidewaySpeed)
            {
                movement.sidewayForce += 10;
            }

        }

    }
}
