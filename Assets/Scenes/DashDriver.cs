using UnityEngine;
using Unity.InputSystem;

public class DashDriver : MonoBehaviour
{
    [SerializeField]float moveSpeed = 0.1f;
    [SerializeField]float steerSpeed = 2f;

    void Update()
    {
        float move = 0f;
        float steer = 0f;

    if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }

    else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }

     if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }

    else if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }

        float moveAmount = move * moveSpeed * Time.delaTime;
        float steerAmount = steer * steerSpeed * Time.delaTime;

        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, steerAmount);
        
    }
}
