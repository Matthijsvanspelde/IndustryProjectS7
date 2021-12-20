using UnityEngine;
using UnityEngine.UI;

public class ButtonUIInteractable : UIInteractable
{
    public override void Interact(Vector3 hitPosition)
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<Button>().onClick.Invoke();
        }       
    }
}
