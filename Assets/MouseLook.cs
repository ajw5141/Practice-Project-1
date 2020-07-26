using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //Mouse Look Variables
    public float mouseSensitivityX = 300f;
    public float mouseSensitivityY = 200f;
    public Transform playerBody;
    float xRotation = 0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // ForMouse Look
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        #region Mouse Look Controls

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivityX * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivityY * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        #endregion





        //Things to Consider:
        //create menu options to adjust sensitivity

        //Questions:
        //Why do my sens defaults in the inspector not match what I coded?
    }
}
