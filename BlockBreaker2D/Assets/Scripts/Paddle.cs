using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    // configuration parameters
    [SerializeField] float minX = 1.0f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthInUnits = 16f;

    Vector2 paddlePos;

	// Use this for initialization
	void Start ()
    {
        paddlePos = new Vector2(transform.position.x, transform.position.y);
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log(Input.mousePosition.y / Screen.width * screenWidthInUnits);

        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        transform.position = paddlePos;
	}
    

}
