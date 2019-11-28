﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLayer1Music : MonoBehaviour 
{

private bool IsInCollider = false;



 
    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player" || IsInCollider) { return; }
        AkSoundEngine.SetRTPCValue("Happy_Drumz", 2);
        AkSoundEngine.SetRTPCValue("Music_Layers_Z1", 0);
        AkSoundEngine.SetRTPCValue("Music_Layers_Z2", 0);
        AkSoundEngine.SetRTPCValue("Music_Layers_Z3", 0);
        AkSoundEngine.SetRTPCValue("Music_Layers_Z4", 0);
    }
}
    