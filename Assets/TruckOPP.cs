using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckOPP : MonoBehaviour
{
   // public float moveSpeed = 5f;
    //private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
      //  rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
        //Vector2 mvmt = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        transform.Translate(Vector2.right * Time.deltaTime *5f );
        //rb.velocity = mvmt;
    }
}
