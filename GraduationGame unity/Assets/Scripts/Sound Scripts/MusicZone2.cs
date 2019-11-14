﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicZone2 : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Awake() 
    {
        AkSoundEngine.PostEvent("StopAll", gameObject);
    }
    void Start()
    {
        
        
        AkSoundEngine.SetState("Zones", "Zone2");
        
        AkSoundEngine.PostEvent("Play_Zone2_Music", gameObject);
        
        AkSoundEngine.SetRTPCValue("Music_Layer_Z2", 1);

        AkSoundEngine.PostEvent("Play_Ambience_Z2", gameObject);
    }
}
