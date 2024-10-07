using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour //From CHATGPT
{
    public Transform target;  // Reference to the character's transform
    public float smoothSpeed = 0.125f;  // Smoothness of the camera movement
    public float fixedY = 5f;  // Fixed Y position for the camera
    public float fixedZ = -10f;  // Fixed Z position for the camera

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = new Vector3(target.position.x, fixedY, fixedZ);  // Only follow the X-axis
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);  // Smoothly interpolate to the target position
            transform.position = smoothedPosition;  // Update the camera position
        }
    }
}

