using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kostka : MonoBehaviour
{
    private float turnSpeed = 90.0f;
    private float horizontalInput;
    private float verticalInput;

    // rotating with mouse inputs
    //public float rotationSpeed = 0.2f;

    public float sensX = 50.0f;
    public float sensY = 50.0f;

    public float minY = -360.0f;
    public float maxY = 360.0f;

    float rotationY = 0.0f;
    float rotationX = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        ////turning the cube
        //horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");
        //transform.Rotate(Vector3.right, verticalInput * Time.deltaTime * turnSpeed);
        //transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);

        if (Input.GetMouseButton(0))
        {
            rotationX += Input.GetAxis("Mouse X") * sensX * Time.deltaTime;
            rotationY += Input.GetAxis("Mouse Y") * sensY * Time.deltaTime;
            rotationY = Mathf.Clamp(rotationY, minY, maxY);
            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }

    }


}
