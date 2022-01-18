using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenderTextureInteraction : MonoBehaviour
{
    [SerializeField] private Camera renderTextureCamera;
    [SerializeField] private GameObject computerScreen;
    [SerializeField] private AudioSource audioSource;
    Vector3 posA, posB;
    public static Vector3 mousePos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {            
            RaycastHit hit;
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         
            if (Physics.Raycast(ray, out hit) && hit.collider == computerScreen.GetComponent<MeshCollider>())
            {
                audioSource.Play();
                var localPoint = hit.textureCoord;
                // convert the hit texture coordinates into camera coordinates
                Ray portalRay = renderTextureCamera.ScreenPointToRay(new Vector2(localPoint.x * renderTextureCamera.pixelWidth, localPoint.y* renderTextureCamera.pixelHeight));
               // Debug.Log(portalRay);
                RaycastHit portalHit;
                // test these camera coordinates in another raycast test
                if (Physics.Raycast(portalRay, out portalHit))
                {
                    posA = portalRay.origin;
                    posB = portalHit.transform.position;
                    mousePos = new Vector3(localPoint.x * renderTextureCamera.pixelWidth, localPoint.y * renderTextureCamera.pixelHeight);
                    if (portalHit.collider.gameObject.GetComponent<Interactable>() != null)
                    {
                       
                       // Debug.Log("Hit");
                        portalHit.collider.gameObject.GetComponent<Interactable>().Interact();
                    }
                }
               
            }

        }
        //Debug.Log("Debug Ray X: " + posB.x + "Debug ray Y" + posB.y);
        Debug.DrawRay(posA, -posB, Color.red);

    }
}
