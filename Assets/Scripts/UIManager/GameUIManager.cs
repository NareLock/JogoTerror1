using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Cinemachine;

public class GameUIManager : MonoBehaviour
{
    [SerializeField]
    private Slider _mouseSenseSlider;
    [SerializeField]
    private Slider _fOVSlider;
    [SerializeField]
    private TextMeshProUGUI _mouseSenseText;
    [SerializeField]
    private TextMeshProUGUI _fOVText;
    [SerializeField]
    private CinemachineVirtualCamera _playerVCamera;
    // Start is called before the first frame update
    void Start()
    {
        _mouseSenseSlider.onValueChanged.AddListener((v) =>
        {
            _mouseSenseText.text = "Mause sensetivity: " + v.ToString("0.00");
            _playerVCamera.GetCinemachineComponent<CinemachinePOV>().m_HorizontalAxis.m_MaxSpeed = v * 50;
        });
        _fOVSlider.onValueChanged.AddListener((v) =>
        {
            _fOVText.text = "Field of view: " + v.ToString("0");
            Camera.main.fieldOfView = v;
        }
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resume()
    {
        _playerVCamera.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
