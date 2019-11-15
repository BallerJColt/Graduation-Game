﻿using System;
using System.Collections;
using System.Collections.Generic;
using KinematicTest.controller;
using UnityEngine;

public class AnimationSwitcher : MonoBehaviour
{
    public RuntimeAnimatorController mmStates;
    public RuntimeAnimatorController interactionStates;
    public MMAnimationController mmAnimatorController;
    public KinematicTestController characterController;

    public Animator animator;

    private void Update()
    {
        Debug.Log(characterController.CurrentCharacterState);
        //basic locomotion
        if (characterController.CurrentCharacterState == PlayerStates.Running &&
            characterController.Motor.GroundingStatus.IsStableOnGround)
        {
            //reset states
            if (characterController.JumpingThisFrame())
            {
                animator.runtimeAnimatorController = interactionStates;
                mmAnimatorController.StopMotionMatching();
                // set jump anim
                animator.SetTrigger("jump");

            }
            //start motion matching
            animator.runtimeAnimatorController = mmStates;
            mmAnimatorController.StartMotionMatching();
        }
        else
        {
            //stop motion matching
            animator.runtimeAnimatorController = interactionStates;
            mmAnimatorController.StopMotionMatching();

            //handle interaction states
            switch (characterController.CurrentCharacterState)
            {
                case PlayerStates.Idling:
                {
                        //set idle loop
                        animator.SetBool("isIdling", true);
                    break;
                }
                case PlayerStates.NoInput:
                {
                        //set idle loop
                        animator.SetBool("isIdling", true);
                        break;
                }
                case PlayerStates.Sliding:
                {
                        //set roll animation
                        animator.SetBool("isSliding", true);
                        break;
                }
                case PlayerStates.Running:
                {
                        animator.SetBool("isIdling", false);
                        animator.SetBool("onLedge?", false);
                        animator.ResetTrigger("ledgeDetected");
                    
                    
                        animator.SetBool("inAir",true);
                        // set fall anim
                    

                    break;
                }
                case PlayerStates.LedgeGrabbing:
                {
                        //set ledge grab
                        animator.SetBool("inAir", false);
                        animator.SetBool("onLedge?", true);
                        animator.SetTrigger("ledgeDetected");
                    break;
                }
                case PlayerStates.Tired:
                {
                    
                        //set wallkick
                        if (characterController.GetLedgeForward())
                        {
                            animator.SetBool("inAir", true);
                            animator.SetBool("onLedge?", false);
                            animator.ResetTrigger("ledgeDetected");
                        }
                        else
                        {
                            animator.SetBool("inAir", true);
                            animator.SetBool("onLedge?", false);
                            animator.ResetTrigger("ledgeDetected");
                        }
                        break;

                        break;
                }
                case PlayerStates.Falling:
                {
                        //set falling again
                        animator.SetBool("inAir", true);
                    break;
                }
            }
        }
    }
}