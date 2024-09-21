using Cinemachine;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private bool _cursorLockState = false;
    [SerializeField]
    private CinemachineVirtualCamera _vCam;
    [SerializeField]
    private PlayerMovement _playerMove;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    public void LockUnlockCursor()
    {
        if (!_cursorLockState)
        {
            _cursorLockState = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            _vCam.enabled = true;
            _playerMove._canMove = true;
        }
        else
        {
            _cursorLockState = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            _vCam.enabled = false;
            _playerMove._canMove = false;
        }
    }
}
