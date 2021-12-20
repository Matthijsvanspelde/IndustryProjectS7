﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenderTextureInteraction : MonoBehaviour
{
    [SerializeField] private Camera renderTextureCamera;
    [SerializeField] private GameObject computerScreen;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         
            if (Physics.Raycast(ray, out hit) && hit.collider == computerScreen.GetComponent<MeshCollider>())
            {
                var localPoint = hit.textureCoord;
                // convert the hit texture coordinates into camera coordinates
                Ray portalRay = renderTextureCamera.ScreenPointToRay(new Vector2(localPoint.x * renderTextureCamera.pixelWidth, localPoint.y* renderTextureCamera.pixelHeight));
               // Debug.Log(portalRay);
                RaycastHit portalHit;
                // test these camera coordinates in another raycast test
                if (Physics.Raycast(portalRay, out portalHit))
                {
                    Debug.DrawRay(portalRay.origin, portalHit.transform.position,Color.red);
                    Debug.Log(portalHit.transform.position);
                    portalHit.collider.gameObject.GetComponent<UIInteractable>().Interact(portalHit.transform.position);
                }
            }
        }

    }
}
