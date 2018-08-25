using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClickSun : MonoBehaviour {

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
        Debug.Log("One of the two suns on this planet. They always mimic each others movements, as though they're in a mirror.");
    }

}

