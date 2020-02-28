using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour
{
	public GameObject stone;
	public float fireRate=0.5f;
	private float nextFire=0.0f; // Initial Value
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>nextFire){
			nextFire=Time.time+fireRate;
			// Object, position and rotation of the new fireRate
			Instantiate(stone, transform.position, Random.rotation);
		}
    }
}
