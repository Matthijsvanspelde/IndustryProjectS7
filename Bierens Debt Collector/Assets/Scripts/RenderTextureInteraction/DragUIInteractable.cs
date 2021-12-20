using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragUIInteractable : UIInteractable
{
    public override void Interact(Vector3 hitPosition)
    {
        Debug.Log("Draggggggggg");
        GetComponent<RectTransform>().position = hitPosition;
    }
}
