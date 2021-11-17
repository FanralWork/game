using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObstacleRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0f, 250f * Time.deltaTime, 0f);
    }
}
