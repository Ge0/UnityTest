using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float amplitude = 0.2f;
    public float omega = 3.0f;
    private float index = 0;

    private float yBase = 0;

    // Use this for initialization
    void Start () {
        yBase = transform.position.y;
	}
    
    public void Update()
    {
        index += Time.deltaTime;
        float y = yBase + amplitude * Mathf.Sin(omega * index);
        transform.localPosition = new Vector3(transform.position.x,
                                              y,
                                              transform.position.z);
    }
}
