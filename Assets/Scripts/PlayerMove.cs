using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    public float moveSpeed;
    public float handling;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    void Movement()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            transform.Rotate(Vector3.back * Time.deltaTime * handling);
        }
        if (Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * handling);
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }
    }
}
