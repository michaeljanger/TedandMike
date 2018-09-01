using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;

     void Awake()
        {
// calling Music player, making one instance and ensuring it stays one persistently.
        if (instance != null)
            {
            Object.Destroy(gameObject);
            print("Object destroyed");
            }
        else
            {
            instance = this;
            Object.DontDestroyOnLoad(gameObject);
            
        }
        }

// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		
	}
}
