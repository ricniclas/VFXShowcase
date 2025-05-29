using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFXController : MonoBehaviour
{
    [SerializeField] public VisualEffect _groundBreakEffect;

    public void PlayEffects()
    {
        _groundBreakEffect.Play();
    }

    
}
