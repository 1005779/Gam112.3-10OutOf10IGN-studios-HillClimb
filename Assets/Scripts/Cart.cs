using UnityEngine;
using System.Collections;

public class Cart : MonoBehaviour {

    Rigidbody RB;

    public float force = 1000.0f;

	// Use this for initialization
	void Start () {

        RB = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Movement()
    {
       if(Input.GetKeyDown("d"))
        {
            
        }
    }
}
