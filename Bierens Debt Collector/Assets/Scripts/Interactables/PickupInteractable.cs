using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupInteractable : Interactable
{
    [SerializeField] private Transform pickupPoint;

    public override void HideToolTip()
    {
        
    }

    public override void ShowToolTip()
    {
        
    }

    private void Update()
    {
        StopInteracion();
    }

    public override void Interact()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody>().useGravity = false;
            transform.position = pickupPoint.position;
            transform.parent = pickupPoint;
        }
    }

    private void StopInteracion() 
    {
        if (Input.GetMouseButtonUp(0))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.useGravity = true;
            transform.parent = null;
        }
    }
}
