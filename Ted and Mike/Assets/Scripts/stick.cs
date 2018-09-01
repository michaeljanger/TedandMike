using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stick : MonoBehaviour {
    public bool sticking;
     

    // Use this for initialization
    void Start () {
      
        sticking = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (sticking == true)
            {
            Destroy (this.GetComponent<Rigidbody>());
            Destroy (this.GetComponent<BoxCollider>());
            }
		
	}
    private void OnCollisionEnter(Collision other)
        {
        if (other.gameObject.CompareTag("Player")&&sticking==false)
            {
            transform.parent = other.transform; //parent object to player
			other.transform.localScale += new Vector3(1F, 1f, 1f); //make player object grow
			PlayMovement movement = other.gameObject.GetComponent<PlayMovement>(); //grab the Playmovement script and put it into definition name
			movement.verticalforce += 1f; //make the player faster vertical when growing
			movement.sidewaysforce += 1f; //make the player faster sideways when growing
			Debug.Log("Growing!");
            sticking = true;
        
            }
        }
    }
