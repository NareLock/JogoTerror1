using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class chuvashader : MonoBehaviour
    
{
    public GameObject respingos;
    public GameObject camera;
    public Collider collision;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        respingos.SetActive(true);
        camera.SetActive(true);
        {
            ParticleSystem.Collision.transform(Scale);
            GameObject.transform.Scale = Vector3(Scale * )
        }
    }
}
