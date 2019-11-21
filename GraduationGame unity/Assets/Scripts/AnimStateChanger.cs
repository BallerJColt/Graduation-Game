﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStateChanger : StateMachineBehaviour
{
    public AnimationSwitcher switcher;
    
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateExit(animator, stateInfo, layerIndex);
    }
}
