using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opp3 : MonoBehaviour
{
    // Start is called before the first frame update
    public float carSpeed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * carSpeed;
    }
}
