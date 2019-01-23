using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour {

    SphereCollider collider;
    GameObject interactedObject;
    [SerializeField] LayerMask objectLayer;

    private void OnValidate()
    {
        collider = GetComponent<SphereCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
      //objectLayer = true;
      //if(other.gameObject.layer = objectLayer.value)
      //interactedObject = other.gameObject;
        
    }

    public void Update()
    {
        if(interactedObject != null)
        {
            //interactedObject.GetComponent<Rigidbody>().velocity = (transform.TransformPoint(interactedObject.transform.position) - transform.position).normalized;
            interactedObject.transform.position = transform.position;
        }
        
    }

}
