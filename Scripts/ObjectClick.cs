using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        // this object was clicked - do something
        Debug.Log("These ruins look otherworldly... Could they be related to the spaceship landing?");
    }

}

