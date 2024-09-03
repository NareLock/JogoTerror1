using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    [SerializeField]
    private Transform _playerRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRotate();
    }

    public void PlayerRotate()
    {
        _playerRotation.transform.localEulerAngles = new Vector3(_playerRotation.transform.localEulerAngles.x, Camera.main.transform.localEulerAngles.y, _playerRotation.transform.localEulerAngles.z);
    }
}
