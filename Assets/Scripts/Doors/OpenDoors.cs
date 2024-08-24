using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{

    [SerializeField]
    private GameObject _door1, _door2;
    [SerializeField]
    private float _currentDoorRotation, _target;
    [SerializeField]
    private float _rotationSpeed = 5f;
    [SerializeField]
    private Vector3 _initial1, _initial2, _final1, _final2;
    [SerializeField]
    private AnimationCurve _speedCurve;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
        }
    }

    private void Update()
    {

        _currentDoorRotation = Mathf.MoveTowards(_currentDoorRotation, _target, _speedCurve.Evaluate(_rotationSpeed * Time.deltaTime));
        _door1.transform.localEulerAngles = new Vector3(-89.617f, _currentDoorRotation, 0);

        //_door1.transform.rotation = Quaternion.Lerp(Quaternion.Euler(_initial1), Quaternion.Euler(_final1), _currentDoorRotation); 
    }
}
