using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    Vector3 newPosition;
    public float speed = 1.2f; 
    
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Health-" + health);
	        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
	    newPosition = transform.position;
	    newPosition.z += speed * Time.deltaTime;
	    transform.position = newPosition;
    }
}
