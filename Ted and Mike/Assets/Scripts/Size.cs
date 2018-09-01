using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour {
	public float sizevalue = 0f; // set initial size for score
	public GameObject player; //call player obj
	

	private void onCollision (Collision other) {
		Debug.Log("collision");
		if (other.gameObject.CompareTag("Object"))
		{
			player.transform.localScale += new Vector3(1F, 1f, 1f); //make player object grow
			sizevalue++; //increase size 
		}
	}
}
