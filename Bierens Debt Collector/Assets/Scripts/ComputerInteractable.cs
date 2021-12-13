using System.Collections;
using UnityEngine;

public class ComputerInteractable : Interactable
{
    [SerializeField] private Camera cam;
    [SerializeField] private MouseLook mouseLook;
    [SerializeField] private float zoomSpeed = 0.5f;
    [SerializeField] private Transform zoomPosition;
    [SerializeField] private Transform startPosition;
    private bool isInteracting = false;
    private bool isLerping = false;

    private void Awake()
    {
        HideToolTip();
    }

    private void FixedUpdate()
    {
        StopInteraction();
    }

    public override void ShowToolTip()
    {
        if (!isLerping)
        {
            canvas.SetActive(true);
        }      
    }

    public override void HideToolTip()
    {
        canvas.SetActive(false);
    }

    public override void Interact()
    {
        if (!isLerping)
        {
            HideToolTip();
            mouseLook.canMove = false;
            StartCoroutine(LerpOverTime(startPosition, zoomPosition, zoomSpeed));
        }       
    }

    private void StopInteraction() 
    {
        if (Input.GetKey(KeyCode.Tab) && isInteracting && !isLerping)
        {
            mouseLook.canMove = true;
            isInteracting = false;
            cam.transform.position = startPosition.position;
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
