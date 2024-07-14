using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //character controls
    public CharacterController _controller;
    public CinemachineVirtualCamera _vCCamera;
    private float _speed = 4f;
    public float _gravity = -45f;
    public float _x;
    public float _z;
    public float x;
    public float z;


    //gravity
    Vector3 _velocity;
    public Transform _groundCheck;
    public float _groundDistance = 0.4f;
    public LayerMask _groundMask;
    private bool _isGrounded;
    public GameObject _cineCamera;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Movment();
        //Drinks Wine for special vision
        if (Input.GetKeyDown(KeyCode.R))
        {
            Invoke("Drink", 2);
        }
        //Throws holy water
        if (Input.GetKeyDown(KeyCode.F))
        {
           Invoke("ThrowWater", 2);
        }
        HoldCross();
        HoldBible();
        if (Input.GetKeyDown(KeyCode.E))
        {
            _vCCamera.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void Movment()
    {
        _isGrounded = Physics.CheckSphere(_groundCheck.position, _groundDistance, _groundMask);
        if (_isGrounded && Input.GetKeyUp(KeyCode.Space))
        {
            _velocity.y = 4;
        }
        else
        {
            x = Input.GetAxis("Horizontal");
            z = Input.GetAxis("Vertical");
        }
        Vector3 move = (transform.right * Input.GetAxisRaw("Horizontal")) / 2.3f + transform.forward * Input.GetAxisRaw("Vertical");
        _controller.Move(_speed * Time.deltaTime * move);
        _velocity.y += _gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);
    }

    private void Drink()
    {
    }

    private void ThrowWater()
    {
    }

    private void HoldCross()
    {
        //Hold up cross
        if (Input.GetKeyDown(KeyCode.Q))
        {

        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {

        }
    }

    private void HoldBible()
    {
        //Holds up bible
        if (Input.GetKeyDown(KeyCode.G))
        {

        }
        else if (Input.GetKeyUp(KeyCode.G))
        {

        }
    }
}
