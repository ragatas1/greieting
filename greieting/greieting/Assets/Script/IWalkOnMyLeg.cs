using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IWalkOnMyLeg : MonoBehaviour
{
    public Rigidbody2D rb;
    public float hopping;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(transform.up*hopping);
        }
    }
}
