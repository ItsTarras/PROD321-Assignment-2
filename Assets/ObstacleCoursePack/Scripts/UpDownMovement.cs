using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownMovement : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float minimumYOffset = 0.0f;
    public float maximumYOffset = 0.0f;
    float minimumYValue;
    float maximumYValue;
    bool isDescending = true;

    // Start is called before the first frame update
    void Start()
    {
        minimumYValue = transform.position.y + minimumYOffset - 3;
        maximumYValue = transform.position.y + maximumYOffset + 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= maximumYValue)
        {
            //Set isDescending so there's a skybox.
            isDescending = true;
        }

        if(transform.position.y <= minimumYValue)
        {
            //Bruh, ain't no way - my homie fell outta the world.
            isDescending = false;
        }


        //Change in the y value per frame is calculated by the move speed multiplied by the time since last frame.
        float yOffset = moveSpeed * Time.deltaTime;

        if(isDescending)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - yOffset, transform.position.z);
        } else {
            transform.position = new Vector3(transform.position.x, transform.position.y + yOffset, transform.position.z);
        }
    }
}
