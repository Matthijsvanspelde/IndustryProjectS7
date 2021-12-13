using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private Camera cam;
    private Interactable interactable;

    private void FixedUpdate()
    {
        Interact();
    }

    public void Interact()
    {
        RaycastHit hit;
        Vector3 CameraCenter = cam.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, cam.nearClipPlane));
        if (Physics.Raycast(CameraCenter, cam.transform.forward, out hit) && hit.transform.CompareTag("Interactable"))
        {
            interactable = hit.transform.gameObject.GetComponent<Interactable>();
            interactable.ShowToolTip();
            if (Input.GetKey(KeyCode.E))
            {              
                interactable.Interact();
            }
        }
        else if (interactable != null)
        {
            interactable.HideToolTip();
        }
    }
}
