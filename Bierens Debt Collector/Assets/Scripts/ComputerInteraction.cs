using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ComputerInteraction : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private MouseLook mouseLook;
    [SerializeField] private float zoomSpeed = 0.5f;
    private Transform zoomPosition;
    private bool isInteracting = false;
    private bool isLerping = false;

    private void FixedUpdate()
    {
        StartInteraction();
        StopInteraction();
    }

    private void StartInteraction() 
    {
        RaycastHit hit;
        Vector3 CameraCenter = cam.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, cam.nearClipPlane));
        if (Input.GetMouseButton(0) && !isLerping)
        {
            if (Physics.Raycast(CameraCenter, cam.transform.forward, out hit) && hit.transform.CompareTag("Computer"))
            {
                zoomPosition = hit.transform.gameObject.GetComponent<Computer>().zoomPoint.transform;
                mouseLook.canMove = false;
                StartCoroutine(LerpOverTime(transform, zoomPosition, zoomSpeed));
            }
        }
    }

    private void StopInteraction() 
    {
        if (Input.GetKey(KeyCode.E) && isInteracting && !isLerping)
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
