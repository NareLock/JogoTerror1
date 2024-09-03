using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest1 : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _questGiverRB;
    [SerializeField]
    private Light _fireLight;
    [SerializeField]
    private BoxCollider _collider;
    [SerializeField]
    private int _stage = 0;
    [SerializeField]
    private MeshRenderer _cubRenderer;
    [SerializeField]
    private GameObject _questUI;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && _stage == 1)
        {
            _cubRenderer.enabled = false;
            _questUI.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            gameObject.SetActive(false);
        }
        if (other.CompareTag("Player") && _stage == 0)
        {
            _questGiverRB.useGravity = true;
            _fireLight.enabled = false;
            _collider.center = new Vector3(0, 0, 0);
            _stage++;
        }
    }
}
