using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    
    //Declaracion de variables
    //[Range(150,250)]
    public float speed = 150.0f;
    public float turnSpeed;
    public float horizontalInput;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        
        this.transform.Translate(speed*Time.deltaTime*Vector3.forward); //(0,0,1)
        this.transform.Translate(turnSpeed*Time.deltaTime*Vector3.right*horizontalInput);
    }
}
