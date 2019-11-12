﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Player/PlayerSettings")]
public class PlayerControllerSettings : ScriptableObject
{
    [Header("Gravity Settings")]
    [Tooltip("Base Gravity, don't modify unless you know what you're doing")]
    public float baseGravity;
    [Tooltip("Gravity affecting the player while jumping up")]
    public float riseGravityMultiplier;
    [Tooltip("Gravity affecting the player while hanging mid-jump. Decrease for more hang time.")]
    public float hangGravityMultiplier;
    [Tooltip("Gravity affecting the player while falling from jumping. Increase for a \"heavier\" fall. ")]
    public float fallGravityMultiplier;
    [Tooltip("Gravity affecting the player while dropping from geometry (without jumping). Increase for a \"heavier\" drop.")]
    public float dropGravityMultiplier;
   
    

    [Header("Running Movement")]
    [Tooltip("Maximum movement speed on ground")]
    public float maxMoveSpeed;
    [Tooltip("Lerping constant in direction change, increase to change directions faster")]
    public float StableMovementSharpness;
    [Tooltip("Lerping constant in turning, increase to turn faster (Currently unused)")]
    public float OrientationSharpness;
    [Tooltip("Time to ramp up to max speed")]
    public float rampUpTime;
    [Tooltip("Time to ramp down to zero")]
    public float rampDownTime;
    [Tooltip("Curve to modify acceleration")]
    public AnimationCurve rampUpCurve;
    [Tooltip("Curve to modify deceleration")]
    public AnimationCurve rampDownCurve;
    
    
    //public Transform groundedTransform;
    //public float groundedDistance;
    [Header("Running Jump Settings")]
    [Tooltip("Jump height multiplier in Zoés")]
    public float jumpHeight;
    [Tooltip("Maximum move speed while in air")]
    public float maxAirMoveSpeed;
    [Tooltip("Falling velocity threshold where the \"fall gravity\" kicks in. Increase to have more hang time")]
    public float hangTimeVelocityThreshold;
    [Tooltip("Input buffer before landing in seconds")]
    public float JumpPreGroundingGraceTime;
    [Tooltip("Coyote time in seconds")]
    public float JumpPostGroundingGraceTime;
    
    
    [Header("Idle Jumping Settings")]
    [Tooltip("Jump height while idling in Zoés")]
    public float idleJumpHeight;
    [Tooltip("Jump move speed when initiated from idle")]
    public float idleAirMoveSpeed;

    [Header("Slide Settings")]
    [Tooltip("The initial slide speed")]
    public float slideMoveSpeed;
    [Tooltip("Jump height while sliding in Zoés")]
    public float slideJumpHeight;
    [Tooltip("Slide duration in seconds")]
    public float slideDuration;
    [Tooltip("Toggle to allow velocity changes while sliding")]
    public bool decelerateWhileSliding;
    [Tooltip("When allowed, this curve will determine the speed change while sliding")]
    public AnimationCurve slideCurve;

    [Header("Ledge Grabbing Settings")]
    //[Tooltip("How long zoe can ledge grab for")]
    //public float hangTime;
    
    [Tooltip("Can zoe automatically fall from a ledge after a time in seconds")]
    public bool canFallFromLedgeAfterDelay;
    [Tooltip("How long before zoe falls from ledge")]
    public float timeBeforeFallFromLedge;
    [Tooltip("How much time needs to pass before zoe can hang from a ledge again")]
    public float graceTimeBeforeHangAgain;
    [Tooltip("Forward Jump height while ledge grabbing in Zoés")]
    public float ledgeGrabForwardJumpHeight;
    [Tooltip("Forward Jump move speed when initiated from ledge grab")]
    public float ledgeGrabForwardAirMoveSpeed;
    [Tooltip("Backwards Jump height while ledge grabbing in Zoés")]
    public float ledgeGrabBackwardsJumpHeight;
    [Tooltip("Backwards Jump move speed when initiated from ledge grab")]
    public float ledgeGrabBackwardsAirMoveSpeed;


    [Header("Misc")]
    [Tooltip("Toggle to allow midair direction changes")]
    public bool canChangeDirectionsMidair;
    [Tooltip("Toggle to allow double jumps")]
    public bool AllowDoubleJump;
    [Tooltip("Unused")]
    public bool AllowJumpingWhenSliding;
}
