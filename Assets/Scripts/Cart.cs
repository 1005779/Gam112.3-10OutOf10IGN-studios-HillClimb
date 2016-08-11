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
	void Update ()
    {
        Movement();
	}

    public void Movement()
    {
       if(Input.GetKey("d"))
        {
			transform.position += transform.forward * 25 * Time.deltaTime;
        }
		else if(Input.GetKey("a"))
		{
			transform.position += transform.forward * -25 * Time.deltaTime;
		}
    }
}
