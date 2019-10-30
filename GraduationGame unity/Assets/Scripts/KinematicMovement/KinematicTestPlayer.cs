﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using KinematicCharacterController;
//using KinematicCharacterController.Examples;
using KinematicTest.controller;
using System.Linq;

namespace KinematicTest.player
{
    public class KinematicTestPlayer : MonoBehaviour
    {
       
        public Transform CameraFollowPoint;
        public KinematicTestController Character;

        private const string MouseXInput = "Mouse X";
        private const string MouseYInput = "Mouse Y";
        private const string MouseScrollInput = "Mouse ScrollWheel";
        private const string HorizontalInput = "Horizontal";
        private const string VerticalInput = "Vertical";

        private void Start()
        {
            //Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Cursor.lockState = CursorLockMode.Locked;
            }

            HandleCameraInput();
            HandleCharacterInput();
        }

        private void HandleCameraInput()
        {
            // Create the look input vector for the camera
            float mouseLookAxisUp = Input.GetAxisRaw(MouseYInput);
            float mouseLookAxisRight = Input.GetAxisRaw(MouseXInput);
            Vector3 lookInputVector = new Vector3(mouseLookAxisRight, mouseLookAxisUp, 0f);

            // Prevent moving the camera while the cursor isn't locked
            if (Cursor.lockState != CursorLockMode.Locked)
            {
                lookInputVector = Vector3.zero;
            }

            // Input for zooming the camera (disabled in WebGL because it can cause problems)
            float scrollInput = -Input.GetAxis(MouseScrollInput);
            

        }

        private void HandleCharacterInput()
        {
            PlayerCharacterInputs characterInputs = new PlayerCharacterInputs();

            // Build the CharacterInputs struct
            ////characterInputs.MoveAxisForward = Input.GetAxisRaw(VerticalInput);
            ////characterInputs.MoveAxisRight = Input.GetAxisRaw(HorizontalInput);
            //characterInputs.inputString = Input.inputString;
            characterInputs.changeDirection = Input.GetKeyDown(KeyCode.Space);
            characterInputs.jumpDown = Input.GetKeyDown(KeyCode.B);
            // Apply inputs to character
            Character.SetInputs(ref characterInputs);
        }
    }
}