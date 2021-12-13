using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public GameObject canvas;

    public abstract void Interact();
    public abstract void ShowToolTip();
    public abstract void HideToolTip();
}
