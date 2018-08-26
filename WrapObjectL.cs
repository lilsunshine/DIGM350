using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapObjectL : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("WillWrap"))
        {
            col.gameObject.transform.position = col.gameObject.transform.position + new Vector3(26.675f, 0.0f, 0.0f);
            Debug.Log("wrap");
        }
    }
}
