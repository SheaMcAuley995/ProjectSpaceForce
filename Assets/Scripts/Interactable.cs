using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable  {

    public Interactable()
    {
        Debug.Log("I worry for my future as a game developer");
    }

    public virtual void Wet()
    {
        Debug.Log("Wet");
    }

    public virtual void Electric()
    {
        Debug.Log("Electric");
    }

    public virtual void Goo()
    {
        Debug.Log("Goo");
    }

    public virtual void Blunt()
    {
        Debug.Log("Blunt force");
    }

    public virtual void Fire()
    {
        Debug.Log("Fire");
    }
}
