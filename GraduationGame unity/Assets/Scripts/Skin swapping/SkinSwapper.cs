﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSwapper : MonoBehaviour
{
    public MeshRenderer[] headMaterialRenderers, outfitMaterialRenderers, bodyMaterialRenderers;

    public PlayerStats playerStats;


    public void SwapSkins(int skinIndex)
    {
        foreach (MeshRenderer mRend in headMaterialRenderers)
        {
            ChangeMaterialInRenderer(mRend, playerStats.allZoeRecolors[skinIndex].zoeHeadMaterial);
        }
        foreach (MeshRenderer mRend in bodyMaterialRenderers)
        {
            ChangeMaterialInRenderer(mRend, playerStats.allZoeRecolors[skinIndex].zoeBodyMaterial);
        }
        foreach (MeshRenderer mRend in outfitMaterialRenderers)
        {
            ChangeMaterialInRenderer(mRend, playerStats.allZoeRecolors[skinIndex].zoeOutfitMaterial);
        }

        Debug.Log("Changed skin to skin #" + skinIndex);
    }

    public void SetSkinFromMainMenu(int skinIndex)
    {
        playerStats.selectedSkin = skinIndex;
    }

    private void ChangeMaterialInRenderer(MeshRenderer meshRenderer, Material material)
    {
        meshRenderer.material = material;
    }
}
