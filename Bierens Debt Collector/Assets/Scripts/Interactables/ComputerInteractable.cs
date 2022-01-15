using System.Collections;
using UnityEngine;

public class ComputerInteractable : Interactable
{
    [SerializeField] private Camera cam;
    [SerializeField] private MouseLook mouseLook;
    [SerializeField] private float zoomSpeed = 0.5f;
    [SerializeField] private Transform zoomPosition;
    [SerializeField] private Transform startPosition;
    [SerializeField] private GameObject crosshair;
    private bool isInteracting = false;
    private bool isLerping = false;

    private void Awake()
    {
        HideToolTip();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            StopInteraction();
        }       
    }

    public override void ShowToolTip()
    {
        if (!isLerping)
        {
            toolTipCanvas.SetActive(true);
        }      
    }

    public override void HideToolTip()
    {
        toolTipCanvas.SetActive(false);
    }

    public override void Interact()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (!isLerping)
            {
                crosshair.SetActive(false);
                HideToolTip();
                mouseLook.canMove = false;
                StartCoroutine(LerpOverTime(startPosition, zoomPosition, zoomSpeed));
                Cursor.lockState = CursorLockMode.None;
                GetComponent<Collider>().enabled = false;
            }
        }           
    }

    public void StopInteraction() 
    {        
        if (isInteracting && !isLerping)
        {
            mouseLook.canMove = true;
            isInteracting = false;
            cam.transform.position = startPosition.position;
            Cursor.lockState = CursorLockMode.Locked;
            GetComponent<Collider>().enabled = true;
            crosshair.SetActive(true);
        }
    }



    private IEnumerator LerpOverTime(Transform startPos, Transform endPos, float duration)
    {
        isLerping = true;
        for (float t = 0f; t < duration; t += Time.deltaTime)
        {
            cam.transform.position = Vector3.Lerp(startPos.position, endPos.position, t / duration);
            cam.transform.rotation = Quaternion.Lerp(startPos.rotation, endPos.rotation, t / duration);
            yield return 0;
        }
        cam.transform.position = endPos.position;
        isInteracting = true;
        isLerping = false;
    }
}
