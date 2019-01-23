using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PipeDamageLevels
{
    Fixed, MediumDamage, Broken
}

public class Pipe : Interactable
{
    PipeDamageLevels pipeDamage;
    
    private void Update()
    {
        CheckPipeStatus();
        
    }

    private void CheckPipeStatus()
    {
        
    }
    void PipeStatus()
    {
        switch (pipeDamage)
        {
            case PipeDamageLevels.Fixed:
                break;
            case PipeDamageLevels.MediumDamage:
                break;
            case PipeDamageLevels.Broken:
                break;
            default:
                break;
        }

    }

    #region Interact Functions
    //wet electric goo blunt fire
    public override void Wet()
    { }
    public override void Electric()
    { }
    public override void Goo()
    { }
    public override void Blunt()
    { }
    public override void Fire()
    { }
    #endregion

}



// goo makes break rate slower
//broken pipe gradually reduces hull integrity
//pipes leak water
