using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class StartScript : MonoBehaviour
{

    [SerializeField]
    private CinemachineVirtualCamera _vCam;
    [SerializeField]
    private PlayerMovement _playerScript;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > .01f || Input.GetAxis("Vertical") > .01f)
        {
            _playerScript.enabled = true;
            _vCam.enabled = true;
            Destroy(this.gameObject);
        }
    }
}
