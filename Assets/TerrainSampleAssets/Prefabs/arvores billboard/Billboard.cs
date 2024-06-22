using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Billboard : MonoBehaviour
    
{
    public Transform Player;
    public Transform Camera;
    
    public Camera billT;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        //Vector3 v = billT.transform.position - transform.position;
        //v.x = 90;
        //v.z = 90;
        //transform.LookAt(billT.transform.position, v);
      //Vector3 directionP = (Player.position - transform.position);
       // transform.rotation = Quaternion.FromToRotation(Vector3.up, -directionP);
        
        // Vector3 direcao = Player.position;
        //transform.LookAt(-direcao, Vector3.up);
       // transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, 90);
       
      
    }
}
