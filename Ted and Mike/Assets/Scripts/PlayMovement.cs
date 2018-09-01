using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovement : MonoBehaviour
    {
    
    public GameObject gameobject;
    public Rigidbody rigidbody;
    public Transform gameobjecttrans;
    public float sidewaysforce = 20f;
    public float verticalforce = 20f;
    public bool jump;

    // Use this for initialization
    void Start()
        {
        gameobjecttrans = gameobject.transform;
        rigidbody = gameobject.GetComponent<Rigidbody>();
        jump = true; 
        
    

        }

    // Update is called once per frame
    void FixedUpdate()
        {


        if (Input.GetKey("w"))
            {
            Debug.Log("W");

             rigidbody.AddForce(Vector3.forward * verticalforce);
            // gameobject.transform.TransformDirection(0f, verticalforce * Time.deltaTime, 0);


            }
        if (Input.GetKey("s"))
            {
            Debug.Log("S");
            rigidbody.AddForce(Vector3.back*verticalforce);
           // gameobject.transform.TransformDirection(0f, -verticalforce * Time.deltaTime, 0);

            }
        if (Input.GetKey("a"))
            {
            Debug.Log("A");
            rigidbody.AddForce(Vector3.left*sidewaysforce);
           // gameobject.transform.TransformDirection(Vector3.forward);

            }
        if (Input.GetKey("d"))
            {
            Debug.Log("D");
            rigidbody.AddForce(Vector3.right * sidewaysforce);
            //gameobject.transform.TransformDirection(-sidewaysforce * Time.deltaTime, 0f, 0);

            }
        if (Input.GetKey("space") && jump == true)
            {

            Debug.Log("JUMP");
            rigidbody.AddForce(Vector3.up * (verticalforce * 2));
            //gameobject.transform.TransformDirection(-sidewaysforce * Time.deltaTime, 0f, 0);

            }
        if (gameObject.transform.position.y < 10)

            {
            jump = true;

            }
        else
            jump = false;

        
        }

        }
    
   
            

        

