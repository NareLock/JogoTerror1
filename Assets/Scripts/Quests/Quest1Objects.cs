using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest1Objects : MonoBehaviour
{
    [SerializeField]
    private GameObject _questUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _questUI.SetActive(true);
            GameManager.Instance.LockUnlockCursor();
        }
    }
}
