using UnityEngine;

public class Quest1 : MonoBehaviour, IInteractable
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
        if (other.CompareTag("Player"))
        {
            _questGiverRB.useGravity = true;
            _fireLight.enabled = false;
            _collider.enabled = false;
        }
    }

    public void Interact()
    {
        GameManager.Instance.LockUnlockCursor();
        _cubRenderer.enabled = false;
        _questUI.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        gameObject.SetActive(false);
    }
}
