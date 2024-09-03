using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSignAnim : MonoBehaviour
{

    [SerializeField]
    private Animator _priestAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Play");
            _priestAnim.SetBool("PlaySign", true);
        }
    }
}
