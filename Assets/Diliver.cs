using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diliver : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    bool hasPackage;
    SpriteRenderer spriteRenderer;
    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    [SerializeField] float timeDestroy = 0.5f;

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("OH no.");
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package all ready");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, timeDestroy);
            
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Diliver done");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;

        }
    
    }
}
