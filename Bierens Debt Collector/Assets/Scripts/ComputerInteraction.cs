using System.Collections;
using UnityEngine;

public class ComputerInteraction : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private MouseLook mouseLook;
    [SerializeField] private float zoomSpeed = 0.5f;
    private Transform zoomPosition;
    private bool isInteracting = false;
    private bool isLerping = false;
    private Computer computer;

    private void FixedUpdate()
    {
        StartInteraction();
        StopInteraction();
    }

    private void StartInteraction()
    {
        RaycastHit hit;
        Vector3 CameraCenter = cam.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, cam.nearClipPlane));
        if (Physics.Raycast(CameraCenter, cam.transform.forward, out hit) && hit.transform.CompareTag("Computer") && !isLerping)
        {
            computer = hit.transform.gameObject.GetComponent<Computer>();
            computer.ShowToolTip();
            if (Input.GetKey(KeyCode.E))
            {
                computer.HideToolTip();
                zoomPosition = computer.zoomPoint.transform;
                mouseLook.canMove = false;
                StartCoroutine(LerpOverTime(transform, zoomPosition, zoomSpeed));
            }
        }
        else if (computer != null)
        {
            computer.HideToolTip();
        }
    }

    private void StopInteraction() 
    {
        if (Input.GetKey(KeyCode.Tab) && isInteracting && !isLerping)
        {
            mouseLook.canMove = true;
            isInteracting = false;
            cam.transform.position = transform.position;
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
