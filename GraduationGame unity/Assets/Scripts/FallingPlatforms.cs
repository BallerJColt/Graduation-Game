﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FallingPlatforms : MonoBehaviour, IOnSceneReset
{
    [SerializeField] private float fallDelayTime;
    private Rigidbody rb;
    private Vector3 initialPosition;
    private Quaternion initalRotation;
    private bool initialUseGravity;
    private bool initialIsActive;
    private bool isFalling;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        initalRotation = transform.rotation;
        initialPosition = transform.position;
        initialIsActive = gameObject.activeSelf;
        initialUseGravity = rb.useGravity;
        isFalling = initialUseGravity;
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        //FallingPlatforms
        //if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        //{
        //}
    }*/

    public void startFallingPlatform()
    {
        if(!isFalling)
            StartCoroutine(startFalling(fallDelayTime));
    }

    IEnumerator startFalling(float delay)
    {
        isFalling = true;
        //Do some animation here ?
        yield return new WaitForSeconds(delay);
        rb.useGravity = true;        
    }

    public void OnResetLevel()
    {
        rb.useGravity = initialUseGravity;
        isFalling = false;
        rb.velocity = Vector3.zero;
        transform.position = initialPosition;
        transform.rotation = initalRotation;
        gameObject.SetActive(initialIsActive);
    }
}
