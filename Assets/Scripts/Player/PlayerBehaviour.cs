using System.Collections;
using System.Collections.Generic;
using UnityEngine;


interface IInteractable
{
    public void Interact();
}
public class PlayerBehaviour : MonoBehaviour
{

    Vector3 rayOrigin = new Vector3(0.5f, 0.5f, 0f);

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = Camera.main.ViewportPointToRay(rayOrigin);
            //Ray ray = new Ray(transform.position, transform.forward);
            Debug.DrawRay(ray.origin, ray.direction * 5, Color.red, 2);
            if (Physics.Raycast(ray, out RaycastHit hitInfo, 5))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObject))
                {
                    interactObject.Interact();
                }
            }
        }
    }
}
