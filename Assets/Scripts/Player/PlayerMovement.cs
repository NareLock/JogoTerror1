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

    //Open Menu
    [SerializeField]
    private GameObject _menu;


    // Start is called before the first frame update
    void Start()
    {
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
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    _vCCamera.enabled = true;
        //}
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _vCCamera.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _menu.SetActive(true);
        }
    }

    private void Movment()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _speed = 8;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
            _speed = 4;

        _isGrounded = Physics.CheckSphere(_groundCheck.position, _groundDistance, _groundMask);
        if (_isGrounded && Input.GetKeyDown(KeyCode.Space))
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

    private void HoldLamp()
    {

    }
}
