using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class FpsShow : MonoBehaviour {
 
    public static float fps;
    public PlayerMovement movement;

    void OnGUI()
    {
        fps = 1.0f / Time.deltaTime;
        GUILayout.Label("FPS: " + (int)fps);
    }
}