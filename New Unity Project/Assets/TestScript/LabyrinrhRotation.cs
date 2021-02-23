using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrinrhRotation : MonoBehaviour
{
    private Touch touch;
    private Vector2 touchPosition;
    private Quaternion rotationX;
    [SerializeField]private float rotateSpeedModifier = 0.1f;
    //Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                rotationX = Quaternion.Euler(
                   -touch.deltaPosition.x * rotateSpeedModifier,  // x-axis
                   0f,    // y-axis
                   0f);
                transform.rotation = rotationX * transform.rotation;


            }


        }
        if(Input.GetMouseButton(0))
        {
            transform.Rotate(rotateSpeedModifier * Time.deltaTime, 0f, 0f);
        }
    }
}