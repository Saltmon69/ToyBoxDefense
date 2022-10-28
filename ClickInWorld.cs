using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickInWorld : MonoBehaviour
{
    private Camera mainCamera;

    private Inputs controls;


    // Start is called before the first frame update
    void Start()
    {
        controls.Mouse.Click.started += _ => StartedClick();
        controls.Mouse.Click.performed += _ => EndedClick();
        mainCamera = Camera.main;
    }

    private void StartedClick()
    {
        
    }

    private void EndedClick()
    {
        DetectObject();
    }


    private void DetectObject()
    {
        Ray ray = mainCamera.ScreenPointToRay(controls.Mouse.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                IClick click = hit.collider.gameObject.GetComponent<IClick>();
                if (click != null)
                    click.onClickAction();
                Debug.Log("3D Hit: " + hit.collider.tag);
            }
        }

        RaycastHit[] hits = Physics.RaycastAll(ray, 200);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i].collider != null)
            {
                Debug.Log("3D Hit All:" + hits[i].collider.tag);
            }
        }
        
        RaycastHit[] hitsNonAlloc = new RaycastHit[1];
        int numberOfHits = Physics.RaycastNonAlloc(ray, hitsNonAlloc);
        for (int i = 0; i < numberOfHits; i++)
        {
            if (hits[i].collider != null)
            {
                Debug.Log("3D Hit Non Alloc:" + hitsNonAlloc[i].collider.tag);
            }
        }
    }



    private void Awake()
    {
        controls = new Inputs();
        controls.Enable();
    }





}
