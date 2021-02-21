using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    public CharacterController2D controller;
    public float runSpeed = 29f;
    float horizontalMove = 0f;

    // Start is called before the first frame update
    void Start()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
        
    }
}
