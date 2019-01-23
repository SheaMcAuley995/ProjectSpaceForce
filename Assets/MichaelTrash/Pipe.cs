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
    int pipeDamage = 0;
    
    public Pipe(PipeDamageLevels damageLevels, float damageTime)
    {
        damageLevels = PipeDamageLevels.Fixed;
        damageTime = 100f;
    }
   
    private void Update()
    {
        CheckPipeStatus();
       
    }
    
    private void CheckPipeStatus()
    {
        if (true)
        {

        }
    }
    void PipeStatus()
    {
        switch (pipeDamage)
        {
            case (int)PipeDamageLevels.Fixed:
                break;
            case (int)PipeDamageLevels.MediumDamage:
                break;
            case (int)PipeDamageLevels.Broken:
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
// broken pipe gradually reduces hull integrity
// pipes leak water
