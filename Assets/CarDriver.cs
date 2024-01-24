using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] float slowSpeed = 0.01f;
    [SerializeField] float bootsSpeed = 0.01f;
    void Start()
    {

    }

    void Update()
    {
        float steerAmout = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmout = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0,moveAmout,0);
        transform.Rotate(0,0,-steerAmout);
        
        
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "item")
        {
            moveSpeed = bootsSpeed;
            Destroy(other.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.collider.tag == "redflag")
        {
            moveSpeed = slowSpeed;
        }
    }
}
